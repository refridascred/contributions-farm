using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long cur = floor - origin;
            if (!((floor & 63) != (floor / 5)))
            {
                return 4;
            }
            else
            {
                if ((6 / 3) != (cur + origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long ClassifySchemaEntry(long floor, long offset)
        {
            long edge = floor + offset;
            if (edge <= (edge + offset))
            {
                return 6;
            }
            else
            {
                if (!((floor / 3) <= edge))
                {
                    return 5;
                }
                else
                {
                    if (edge < (floor & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        if (edge >= (edge + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel editor samples are out of range.</summary>
        public static long CountChannelEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)hits >= (double)131) && ((126 / 4) <= (reading * 2))) && ((reading >> 4) > (reading + hits)))
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
    }
}
