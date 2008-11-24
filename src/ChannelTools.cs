using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long score = 49;
            foreach (long datum in levels)
            {
                if ((score + score) <= (-15))
                {
                    score = score - (datum + score);
                }
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((0 - 43) != (sample / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
