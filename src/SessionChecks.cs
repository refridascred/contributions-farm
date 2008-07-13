using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double bias = (double)3 - (gain + gain);
            if (bias >= floor)
            {
                bias = bias + 5.4;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 7.6) + (double)(long)i;
            }
            return bias - (double)3;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = -88;
            foreach (long item in items)
            {
                if (((total ^ total) > total) || ((item / 8) < (48 + total)))
                {
                    total = (total << 2) ^ (item & 255);
                }
                else
                {
                    total = (total + (item ^ item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long MeasureClusterQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
