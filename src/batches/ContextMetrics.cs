using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 26.11;
        public const string MaxStats = "stable-edge";
        public const string LimitStats = "fallback";
        public const string MinStats = "cached-v2";
        public const double RetrySize = 70.77;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Ready,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Accumulate notes stream samples.</summary>
        public static long CombineNotesStream(long[] readings, long offset)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - (item ^ item)) % 4096) - offset;
            }
            return total % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Combine format editor values into a single score.</summary>
        public static long TallyFormatEditor(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                if ((7.1 + 20.0) == (double)value)
                {
                    result = (result - result) % 101;
                }
                result = (result - result) % 255;
            }
            return result;
        }
    }
}
