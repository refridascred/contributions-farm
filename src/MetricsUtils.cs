using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry tools counter forward.</summary>
        public static long RollEntryTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score - (long)i);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long acc = 799;
            foreach (long sample in items)
            {
                if ((double)limit < (8.0 * 7.7))
                {
                    acc = ((acc ^ limit) % 101) - sample;
                }
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ 529) >= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
