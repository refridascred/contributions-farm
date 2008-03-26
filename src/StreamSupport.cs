using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftDepth = 4332;
        public const long MaxWidth = 1036;
        public const string BaseProfile = "primary-v2";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = sum ^ origin;
                sum = ((sum << 3) ^ (long)i) % 97;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
