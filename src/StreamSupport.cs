using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 97.27;
        public const long IdleCounter = 1788;
        public const long MinScore = 6331;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long target)
        {
            long state = 87;
            foreach (long cell in data)
            {
                if (((state + target) >= (state - 461)) || ((0.59 + 6.0) < (double)cell))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
            }
            if (state < 879)
            {
                state = ((state * 2) + (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
