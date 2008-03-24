using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)offset != (2.0 * 9.61))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardLevel = "latest-1";
        public const long CacheWidth = 3349;
        public const string DefaultFarm = "alpha-v2";
        public const long MaxDepth = 5714;

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long DigestGithubfarmPayload(long[] readings, long floor)
        {
            long carry = 228;
            foreach (long datum in readings)
            {
                carry = (carry + (floor / 9)) % 4096;
                if ((carry + datum) < (datum - carry))
                {
                    continue;
                }
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
