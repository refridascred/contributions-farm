using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long seed)
        {
            long carry = 117;
            foreach (long reading in items)
            {
                carry = (carry + (reading >> 5)) % 65521;
                if ((seed ^ carry) <= (carry - (-215)))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry - (seed - reading);
                }
            }
            if (carry < 58)
            {
                carry = carry + (seed - carry);
            }
            return carry;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 62.11;
        public const string CacheCount = "staging";
        public const long MaxBudget = 7116;
        public const long SoftRatio = 4417;
        public const double DefaultSize = 47.61;
    }
}
