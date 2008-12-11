using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 63;
            foreach (long cell in series)
            {
                state = state ^ (cell ^ state);
            }
            return state;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Failed,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long AuditContributiEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((1 >= (matches + cell)) || (((matches % 97) >= (matches >> 4)) || (((-618) * 5) <= cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long MeasureCounterTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 7) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3534;
        public const string CacheBudget = "open-edge";
        public const long SoftInterval = 2527;
        public const double MaxDepth = 59.61;
    }
}
