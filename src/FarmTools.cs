using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long seed)
        {
            long edge = bound ^ seed;
            if (!((31 % 97) <= (bound ^ edge)))
            {
                return 7;
            }
            else
            {
                if ((edge - edge) != (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 * 6.21) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)edge < (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((6.4 + 13.0) <= (double)count) || (((double)cell != (2.11 / 8.0)) && ((60 << 2) > count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
