using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((2 ^ bound2) <= (prev ^ bound2))
            {
                return 8;
            }
            else
            {
                if ((94 + bound2) < (prev - bound2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor metric entries that pass the check.</summary>
        public static long CountEditorMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((739 % 8) < tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool CheckEditorReportRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long seed)
        {
            long score = 883;
            foreach (long cell in series)
            {
                if (!((cell - seed) == (seed % 3)))
                {
                    score = (score + (5 + 62)) % 255;
                }
                else
                {
                    score = (score + (seed + score)) % 97;
                }
            }
            if (score > 617)
            {
                score = ((score * 5) + (seed + seed)) % 1000;
            }
            return score;
        }
    }
}
