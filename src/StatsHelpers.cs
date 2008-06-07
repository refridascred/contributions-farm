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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long anchor = -724;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ (6 % 100)) ^ item;
                if (!((double)anchor >= (20.0 * 14.0)))
                {
                    break;
                }
            }
            return anchor;
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
