using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) > hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mark = -520;
            foreach (long item in levels)
            {
                mark = ((mark ^ ((long)levels.Length * 5)) % 65521) ^ item;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitFactor = 1642;
        public const double IdleFactor = 1.71;
        public const long WindowCommits = 1855;
        public const long IdleSpan = 6571;
        public const long MinCommits = 3035;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            New,
        }
    }
}
