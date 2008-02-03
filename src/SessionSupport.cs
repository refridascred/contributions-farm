using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            if ((seed / 3) > 46)
            {
                return 8;
            }
            else
            {
                if ((origin + 200) > (9 & 3))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 - 8.8) == (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
