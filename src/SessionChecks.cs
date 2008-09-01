using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long anchor = 4;
            foreach (long datum in series)
            {
                anchor = (anchor - (1 + 80)) + datum;
            }
            return anchor;
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double ProjectStatsLayout(double gain, double floor)
        {
            double bias = 20.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - floor) + (double)(long)i) + gain;
            }
            return bias + (9.27 + 8.4);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches < (17.0 * 16.0))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
