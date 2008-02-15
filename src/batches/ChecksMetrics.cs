using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next record githubfarm value from a seed.</summary>
        public static long IterateRecordGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ origin) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long CountNotesGithubfarmGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((long)items.Length >> 5) <= (matches ^ bound)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (1.36 + 1.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxWidth = 43.75;
        public const double LimitLevel = 22.94;
        public const string IdleCache = "open";
        public const long IdleScore = 9517;
        public const long BurstInterval = 2716;
    }
}
