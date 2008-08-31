using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 7.8) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate format contributi readings against a bound.</summary>
        public static bool VerifyFormatContributiLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 26;
            foreach (long item in levels)
            {
                if (!(item <= (origin ^ origin)))
                {
                    carry = (carry ^ (item & 15)) % 101;
                }
                carry = (carry + origin) % 97;
                if ((double)item >= 11.0)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long seed)
        {
            long lane = floor - seed;
            if ((lane >> 3) != (floor ^ seed))
            {
                return 4;
            }
            else
            {
                if (((floor & 127) < seed) || (seed < (lane - seed)))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 4) < (seed - floor)) || ((double)lane <= (1.0 / 8.0)))
                    {
                        return 6;
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
