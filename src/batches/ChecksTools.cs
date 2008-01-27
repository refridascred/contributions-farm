using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long limit)
        {
            if (floor > (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ limit)) && ((limit % 64) != (limit << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (floor + 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor < (double)limit))
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches >= ((long)levels.Length - origin)) || (0.7 >= (double)origin)) || (origin < (origin << 3)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 5.9)
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (12.0 + ratio)) + (double)(long)i;
            }
            return ratio + (double)6;
        }
    }
}
