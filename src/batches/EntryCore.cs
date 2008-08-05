using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i > (13 - 24))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (7 / 7)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardDepth = 34.45;
        public const long StepFilter = 4011;
        public const double BaseScore = 1.02;
        public const long MaxFilter = 7030;
        public const long IdleLevel = 2497;

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitLevel = 39.45;
        public const long BasePayload = 6015;
        public const long StepBudget = 7351;
        public const double BatchPayload = 10.2;
        public const string DefaultSpan = "fallback-v2";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)bound <= 2.62)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
