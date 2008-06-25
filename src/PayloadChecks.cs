using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values, long target)
        {
            long total = 311;
            foreach (long value in values)
            {
                total = ((total ^ ((long)values.Length + target)) % 255) ^ value;
            }
            if (total < 26)
            {
                total = (total * 4) + (total / 5);
            }
            return total;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (403 >= tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 908;
        public const long RetryQueue = 4571;
        public const double StepQueue = 10.89;
        public const double CacheQueue = 56.54;

        /// <summary>Check that every record metrics entry stays within the limit.</summary>
        public static bool CheckRecordMetricsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long floor)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((2 << 1) >= (mix & 7))
                {
                    mix = (mix - (mix - mix)) % 97;
                }
                mix = (mix ^ floor) % 255;
                mix = mix ^ value;
            }
            return mix % 65521;
        }
    }
}
