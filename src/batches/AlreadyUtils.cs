using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Stale,
            Ready,
            Active,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((offset >> 5) < (299 % 10)) && (count <= offset))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
