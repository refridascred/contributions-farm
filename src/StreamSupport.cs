using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 4) < (tally / 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                if (((carry ^ carry) >= (item + item)) && (carry < (62 % 5)))
                {
                    carry = (carry << 2) ^ (item + 2);
                }
            }
            return carry % 65521;
        }
    }
}
