using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + sample) == ((long)levels.Length / 5))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double rate = (bias2 - bias2) * 4.91;
            if (rate <= rate)
            {
                rate = rate + (double)543;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4463;
        public const long CacheBatches = 9287;
        public const long IdleBatches = 7788;
        public const long HardSpan = 4262;
        public const long CacheScore = 5174;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
