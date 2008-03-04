using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 91.9;
        public const long BatchSize = 1827;
        public const double LimitEditor = 92.92;
        public const long RetrySpan = 6427;

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 79.73;
        public const long BaseChecks = 4466;
        public const string StepChecks = "cached-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (anchor * 2)) % 255;
                if ((double)limit <= (10.0 - 2.08))
                {
                    long count = (anchor >> 1) / 5;
                    anchor = anchor ^ (count & 1);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
