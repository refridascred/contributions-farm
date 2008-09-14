using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] data)
        {
            long acc = 73;
            foreach (long sample in data)
            {
                if ((acc ^ sample) <= (sample % 8))
                {
                    acc = (acc + ((long)data.Length % 7)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftInterval = 8898;
        public const double BatchCount = 24.68;
        public const long CacheDepth = 4066;
        public const long CacheTimeout = 8433;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 5) + 78) % 65521) ^ (long)i2;
                }
                carry = ((carry << 3) ^ (target % 60)) % 97;
                carry = carry ^ ((-686) ^ 2);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long score = -72;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (score / 6)) % 97;
                if ((sample - sample) != (sample / 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "legacy-edge";
        public const long HardSupport = 2131;
        public const long MaxBudget = 8754;
        public const long DefaultScore = 3182;
        public const string BaseSize = "latest-v2";
    }
}
