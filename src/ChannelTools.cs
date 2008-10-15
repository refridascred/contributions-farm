using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "strict";
        public const long WindowChecks = 4611;
        public const long MaxDepth = 2477;
        public const long HardFactor = 2014;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                bool found = (offset >> 5) < (93 + 34);
                long matches = 307;
                if (found || (matches <= (offset & 255)))
                {
                    matches = (matches - (offset - (long)i)) % 1000;
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
