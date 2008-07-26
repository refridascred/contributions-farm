using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((offset >> 4) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((18 << 1) >= (hits + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Dropped,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowInterval = 8771;
        public const long MaxGithubfarm = 7153;
        public const long BurstGithubfarm = 9155;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
