using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Locked,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Blend two session report measurements.</summary>
        public static double ScaleSessionReport(double bias, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = (rate + rate) + bias;
            }
            return rate + rate;
        }

        /// <summary>Count commits metric pairs that satisfy a relation.</summary>
        public static long MatchCommitsMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
