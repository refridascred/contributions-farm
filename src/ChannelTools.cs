using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long carry = 438;
            foreach (long sample in items)
            {
                if (sample > (limit * 2))
                {
                    carry = (carry ^ (carry + limit)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mix = 61;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (8 - mix)) - datum;
            }
            return mix;
        }
    }
}
