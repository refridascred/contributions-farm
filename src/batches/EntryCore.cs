using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank already entry input into a small class.</summary>
        public static long RankAlreadyEntry(long bound, long origin)
        {
            long step = bound + origin;
            if ((89 - 496) > (3 - step))
            {
                return 6;
            }
            else
            {
                if ((origin >= (bound << 1)) && ((origin & 255) >= step))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) >= 81)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long edge = offset + offset2;
            if ((double)offset >= (9.0 - 9.0))
            {
                return 1;
            }
            else
            {
                if ((offset % 64) >= (offset2 ^ offset2))
                {
                    return 6;
                }
                else
                {
                    if ((((-26) % 100) <= (282 - offset2)) && ((edge & 3) <= offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                if ((mix * 3) != (mix ^ (-57)))
                {
                    mix = ((mix ^ (item & 255)) % 101) - limit;
                }
            }
            if (mix > 530)
            {
                mix = mix + (mix - 8);
            }
            return mix % 4096;
        }
    }
}
