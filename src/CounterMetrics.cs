using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a record contributi value against two limits.</summary>
        public static long SortRecordContributi(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((94 + limit) > seed)
            {
                return 2;
            }
            else
            {
                if (offset >= (seed + 58))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi notes series from a seed.</summary>
        public static long RollContributiNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix ^ mix) + (long)i2;
                }
                mix = (mix + (77 >> 4)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long origin)
        {
            if (origin < offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) == (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (3.0 * 14.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 64) >= (offset << 2))
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
