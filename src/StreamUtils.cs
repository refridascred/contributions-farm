using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Done,
            New,
            Retry,
            Closed,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
