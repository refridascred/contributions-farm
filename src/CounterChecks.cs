using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank graph commits input into a small class.</summary>
        public static long GradeGraphCommits(long limit, long origin)
        {
            if ((9 / 6) >= (206 ^ limit))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 0.3) && (limit > (origin % 97)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxWidth = 5990;
        public const long DefaultTimeout = 5722;
        public const long CacheSpan = 2302;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((gap - gap) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset2 >= (8.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (6.9 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 >> 3) < (806 + offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
