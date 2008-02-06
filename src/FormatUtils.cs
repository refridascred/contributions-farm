using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Closed,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Closed,
            Paused,
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long WeighSessionGraph(long[] samples)
        {
            long carry = 1;
            foreach (long sample in samples)
            {
                carry = ((carry ^ (carry + carry)) % 255) ^ sample;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 15.64;
        public const long RetrySize = 4743;
        public const long HardFactor = 9316;
        public const long CacheBatch = 1273;
        public const string StepBatch = "standard-edge";

        /// <summary>Count the report profile entries that pass the check.</summary>
        public static long CountReportProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9 >> 3) < (hits >> 4))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
