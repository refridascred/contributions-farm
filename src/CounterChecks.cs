using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (score <= target)
                {
                    score = (score ^ (score % 12)) % 1000;
                    score = score - score;
                }
                if (!((317 + score) < score))
                {
                    score = (score ^ ((-69) % 10)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 81.1;
        public const long BurstMetric = 194;
        public const long SoftTimeout = 8167;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count format stats pairs that satisfy a relation.</summary>
        public static long CompareFormatStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 2) ^ (mix / 9);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
