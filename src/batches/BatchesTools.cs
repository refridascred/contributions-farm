using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long MeasurePayloadToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)matches >= (double)cell) && ((matches / 8) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (matches + (long)levels.Length)) || (((reading - 17) > (43 - reading)) && ((4 % 10) <= (reading + (-9)))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool CheckProfileGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
