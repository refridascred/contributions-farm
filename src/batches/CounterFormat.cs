using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit checks record readings against a rule.</summary>
        public static long CountChecksRecordMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (7.8 > (double)(long)samples.Length)
                {
                    matches = ((matches + 1) ^ sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Ready,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool GuardReportFormatRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
