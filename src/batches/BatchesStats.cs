using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long MeasureMetricsEditorOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((seed > (entry << 2)) || ((28 - entry) <= (entry ^ seed))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (scale * 0.5)) - (double)(long)i) - offset;
            }
            return mean + scale;
        }
    }
}
