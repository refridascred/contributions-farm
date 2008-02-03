using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long step)
        {
            if ((floor + step) != (floor << 1))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (step + step))
                {
                    return 4;
                }
                else
                {
                    return 2;
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
