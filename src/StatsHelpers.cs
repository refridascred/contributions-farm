using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) <= reading)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double scale2 = (double)(391 % 2);
            if (scale2 >= (floor / 5.0))
            {
                scale2 = scale2 - (scale + scale2);
            }
            else
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (floor + floor);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(19.0 >= (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Failed,
            Closed,
        }
    }
}
