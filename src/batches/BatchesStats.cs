using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "cached-edge";
        public const long BaseInterval = 5346;
        public const long BaseProfile = 110;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 3462;
        public const double BurstTimeout = 14.62;
        public const double MaxCount = 48.89;
        public const long IdleWindow = 4205;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit * 5) == (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
