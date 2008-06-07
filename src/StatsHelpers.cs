using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel metric samples.</summary>
        public static long TotalChannelMetric(long[] readings, long offset)
        {
            long acc = 847;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (acc - offset)) ^ datum;
            }
            return acc % 1000;
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

        /// <summary>Scale a batches entry figure with a bias.</summary>
        public static double BlendBatchesEntry(double scale, double offset)
        {
            double rate = (double)71 * 1.83;
            if (rate < scale)
            {
                rate = rate - (rate * 4.07);
            }
            return rate - offset;
        }
    }
}
