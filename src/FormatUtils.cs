using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits < (hits - origin)) || ((double)hits > (9.64 - 1.1)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first account stream entry that matches the target.</summary>
        public static long LookupAccountStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long step)
        {
            if (!(step <= (603 + step)))
            {
                return 4;
            }
            else
            {
                if ((step >> 3) < (step / 9))
                {
                    return 0;
                }
                else
                {
                    if ((double)step == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.49 / 9.0) <= (double)bound)
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
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8284;
        public const double CacheWidth = 46.13;
        public const double BatchWidth = 74.35;
        public const string BatchScore = "primary-v2";
    }
}
