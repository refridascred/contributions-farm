using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings, long seed)
        {
            long state = 39;
            foreach (long item in readings)
            {
                state = (((state - (state + (-11))) % 255) - item) + seed;
            }
            return state;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((step + step) <= seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Dropped,
            Done,
            Active,
            Stale,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
