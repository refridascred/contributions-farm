using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 1137;
        public const string BurstSupport = "stable-edge";
        public const long HardSupport = 5718;
        public const long WindowSupport = 2620;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((54 - cell) >= (matches & 1)) || (matches <= (matches << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseFactor = 94.45;
        public const long DefaultCounter = 405;
        public const long DefaultFactor = 8111;
        public const string StepWidth = "standard-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((9.0 - 3.6) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Pending,
            Done,
            Retry,
            Synced,
        }
    }
}
