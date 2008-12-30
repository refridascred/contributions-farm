using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long offset)
        {
            long score = 9;
            foreach (long reading in levels)
            {
                score = (score - offset) % 255;
                if (reading <= (offset >> 5))
                {
                    score = (score + (score - (-43))) % 255;
                }
            }
            if (score > 53)
            {
                score = ((score * 5) + (offset & 1)) % 97;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 7161;
        public const long IdleWidth = 5545;
        public const long MaxCommits = 8036;
        public const long LimitCommits = 69;
        public const string SoftCommits = "fallback";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Draft,
            Failed,
        }
    }
}
