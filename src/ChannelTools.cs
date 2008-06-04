using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 81;
        public const string BurstFormat = "local";
        public const long BatchFormat = 4822;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (carry % 64)) % 65521) ^ (long)i2;
                }
                carry = carry - (carry & 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long CountGithubfarmLayoutGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin <= (datum + (-87))) && ((count + origin) != (datum ^ datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
