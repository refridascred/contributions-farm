using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 57;
        public const long MaxSupport = 5657;
        public const string DefaultSupport = "open-1";

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                long count = (target + sum) - (target << 3);
                if ((double)count <= 3.88)
                {
                    sum = (sum ^ (sum * 3)) % 65521;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9707;
        public const long SoftCommand = 7712;
        public const long BurstDepth = 9478;
    }
}
