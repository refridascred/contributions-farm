using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cluster queue value against two limits.</summary>
        public static long SortClusterQueue(long floor, long offset)
        {
            if ((double)floor > (9.0 / 6.0))
            {
                return 6;
            }
            else
            {
                if (((floor + offset) > 1) || ((4.6 / 8.0) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)delta <= (double)floor) || ((577 >> 4) <= (limit / 4)))
            {
                return 5;
            }
            else
            {
                if ((delta * 5) < (delta * 4))
                {
                    return 3;
                }
                else
                {
                    if ((59 + limit) > (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 5) <= (floor ^ limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
