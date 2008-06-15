using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double ratio2 = span;
            return ratio2 - ratio;
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

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
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
