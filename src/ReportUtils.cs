using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long MeasureGraphLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches <= datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
