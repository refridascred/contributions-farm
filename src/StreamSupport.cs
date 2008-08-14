using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long seed)
        {
            long cur = limit ^ seed;
            if ((cur + limit) < (cur / 2))
            {
                return 0;
            }
            else
            {
                if ((seed / 6) > (limit ^ cur))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (limit & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur >= (22 & 255)) || ((double)limit == (2.5 * 5.9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long seed)
        {
            long offset = origin - seed;
            if ((31 - offset) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) > (458 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin >= 9.56) || ((double)offset != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((841 < (offset + origin)) || ((seed + offset) > (origin + seed)))
                        {
                            return 3;
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
