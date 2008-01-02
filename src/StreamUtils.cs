using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long offset2)
        {
            if (((offset / 6) < (offset2 + offset2)) && ((offset2 + offset) == (offset ^ offset2)))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (1.6 - 16.0))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset != (8.24 + 9.9)) || ((offset2 + offset2) != (5 * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset <= (677 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long step)
        {
            long total = 6;
            foreach (long entry in values)
            {
                total = (((total << 2) ^ total) ^ entry) - step;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                acc = (acc * 2) + (reading * 4);
            }
            if (acc > 28)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Validate channel layout readings against a bound.</summary>
        public static bool VerifyChannelLayoutBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Stale,
            Pending,
            Paused,
            Draft,
        }
    }
}
