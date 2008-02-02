using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long CountEntrySupportOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.34 - 8.0) != (double)cell)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            New,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Roll a stats counter counter forward.</summary>
        public static long DeriveStatsCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) <= ((-9) >> 3))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
