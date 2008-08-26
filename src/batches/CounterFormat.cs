using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long offset)
        {
            long slot = target ^ offset;
            if ((871 % 5) < (target & 3))
            {
                return 8;
            }
            else
            {
                if (!(slot >= (target - 877)))
                {
                    return 1;
                }
                else
                {
                    if (offset > target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6.0 * 3.7) > (double)target) && ((offset / 5) <= (offset + 960)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
