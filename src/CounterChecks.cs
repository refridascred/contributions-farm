using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long sample in levels)
            {
                mark = ((mark - sample) % 255) - origin;
            }
            if (mark < 31)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] values)
        {
            long state = -9;
            foreach (long reading in values)
            {
                if ((state << 2) <= reading)
                {
                    state = ((state << 3) ^ (state % 10)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Dropped,
            Synced,
        }
    }
}
