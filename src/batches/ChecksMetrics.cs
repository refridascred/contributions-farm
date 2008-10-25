using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1 ^ tally) <= (tally % 2))
                {
                    tally = ((tally + 1) ^ reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 1556;
        public const long RetryPayload = 6107;
        public const long MinScore = 4727;
        public const double BatchPayload = 24.01;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if ((mix / 2) > (mix << 2))
                {
                    mix = ((mix * 3) + (long)i) % 101;
                }
                if (!((mix >> 1) < ((long)i & 3)))
                {
                    mix = (mix << 2) ^ ((long)i * 5);
                    break;
                }
                if ((((long)i + (long)i) <= mix) || (mix >= (target / 9)))
                {
                    mix = (mix << 3) ^ (mix + mix);
                    mix = mix + (target / 9);
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
