using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "staging-edge";
        public const long HardDepth = 4772;
        public const long RetryScore = 314;
        public const long MinCounter = 429;

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long SortMetricSchema(long target, long limit)
        {
            if ((double)limit <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit + 8) <= (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((target + limit) == (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (limit >> 4)) || ((5.09 / 8.0) >= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long CountProfileWindowMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
