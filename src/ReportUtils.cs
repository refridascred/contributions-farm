using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((7.6 < (double)matches) && (2.8 <= (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Draft,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Audit notes route readings against a rule.</summary>
        public static long TallyNotesRouteHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((524 >> 1) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
