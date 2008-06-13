using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long target, long target2)
        {
            if (target2 >= (target2 ^ target))
            {
                return 3;
            }
            else
            {
                if ((target + target2) != (target - 2))
                {
                    return 8;
                }
                else
                {
                    if (((target ^ target) != (target2 & 255)) && ((8 * 3) < (target % 97)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 < (target % 7)) || ((target2 * 3) < target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 9) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
