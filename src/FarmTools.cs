using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
