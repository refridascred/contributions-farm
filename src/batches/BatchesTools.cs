using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double rate = (double)((-6) - 825);
            if (rate > (rate * 8.0))
            {
                rate = rate - (gain + gain);
            }
            return rate - span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (hits <= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Done,
            Ready,
            Paused,
            Synced,
        }
    }
}
