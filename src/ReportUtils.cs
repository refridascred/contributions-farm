using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a graph queue counter forward.</summary>
        public static long SeriesGraphQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Failed,
            Retry,
            Closed,
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
