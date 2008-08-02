using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Draft,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long target2)
        {
            if (((double)target >= (7.7 * 8.16)) || ((target2 + 378) <= (893 >> 3)))
            {
                return 4;
            }
            else
            {
                if (target > (target2 - 19))
                {
                    return 0;
                }
                else
                {
                    if (((target2 << 2) > (1 << 2)) && ((target2 * 4) <= target2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target < (8.0 / 5.0))
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
