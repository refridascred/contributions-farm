using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (floor + weight) - (weight * 9.0);
            if (gain <= floor)
            {
                gain = gain - (double)238;
            }
            return gain - 6.75;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long seed)
        {
            if ((seed - target) > (seed - 538))
            {
                return 3;
            }
            else
            {
                if ((double)seed != (6.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 66;
        public const double LimitMetrics = 53.84;
        public const long WindowMetrics = 6127;
        public const long RetryDepth = 6654;
        public const double MinMetrics = 93.82;

        /// <summary>Derive the next metrics notes value from a seed.</summary>
        public static long IterateMetricsNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((long)i <= 55)
                {
                    acc = (acc * 2) + ((long)i - acc);
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Locked,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
