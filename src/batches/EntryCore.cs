using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long IterateBufferOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long SortRecordSession(long step, long target)
        {
            if ((step - 91) <= 952)
            {
                return 7;
            }
            else
            {
                if (step >= (target << 3))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) > (1 + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long ClassifyEditorAccount(long floor, long offset)
        {
            if (offset >= (floor - (-5)))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (8.73 + 6.9))
                {
                    return 3;
                }
                else
                {
                    if ((1.15 * 1.07) == (double)offset)
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
}
