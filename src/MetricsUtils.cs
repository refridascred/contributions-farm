using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long limit)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((limit ^ 1) < (93 << 2))
                {
                    carry = carry ^ (entry - 76);
                }
            }
            if (carry > (-7))
            {
                carry = (carry << 3) ^ (limit % 8);
            }
            return carry;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 7) != ((long)items.Length ^ matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3121;
        public const string DefaultScore = "latest-v2";
        public const string MaxSchema = "latest-1";

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 172;
            foreach (long entry in items)
            {
                score = (score << 2) ^ ((-13) << 1);
                if ((entry + (-4)) <= (entry % 100))
                {
                    score = score - (score + entry);
                }
                else
                {
                    score = ((score * 4) + score) % 1000;
                }
            }
            if (score > 32)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }
    }
}
