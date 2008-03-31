using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            if (((9.36 + 4.47) != (double)bound2) && (((-802) / 6) >= (bound2 / 5)))
            {
                return 4;
            }
            else
            {
                if ((6.2 * 0.7) == (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (!((bound2 - 247) >= (bound2 % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long MeasureChecksEntryOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ limit) == (limit * 2)) || ((hits <= limit) || ((hits - limit) > (entry & 15))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long floor)
        {
            long lane = step + floor;
            if ((0 << 1) > lane)
            {
                return 2;
            }
            else
            {
                if (step <= 662)
                {
                    return 4;
                }
                else
                {
                    if (step > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 2) > 4)
                        {
                            return 1;
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
