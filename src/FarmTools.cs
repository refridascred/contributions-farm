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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstScore = 7444;
        public const double StepSize = 53.5;
        public const long BaseReport = 6051;
        public const long DefaultDepth = 874;
        public const long IdleReport = 4042;

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
