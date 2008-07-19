using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((anchor - 8) < ((long)i * 2)) || (((long)i + limit) <= anchor))
                {
                    anchor = (anchor ^ (anchor - limit)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (10 + 7)) % 97;
                }
                anchor = (anchor + (anchor + (long)i)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value ^ hits) > (value + hits)) && ((hits & 31) != (739 - value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
