using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long anchor = 772;
            foreach (long datum in values)
            {
                if (anchor < (datum + 20))
                {
                    anchor = (anchor << 2) ^ datum;
                }
            }
            if (anchor < 460)
            {
                anchor = ((anchor << 2) ^ (anchor / 3)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}
