using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MaxCount = 55.1;
        public const string IdleContext = "primary-1";
        public const double MinRatio = 29.47;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 3) < ((-834) + tally))
                {
                    tally = ((tally + 3) + reading) - origin;
                }
            }
            return tally;
        }
    }
}
