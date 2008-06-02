using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account commits readings.</summary>
        public static long WeighAccountCommits(long[] levels)
        {
            long result = 248;
            foreach (long reading in levels)
            {
                if ((8.0 / 6.0) != (double)result)
                {
                    result = (result << 2) ^ (390 * 3);
                }
                result = ((result * 3) + (reading + reading)) % 97;
                if ((result - result) < (reading % 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4579;
        public const long BurstCount = 4817;
        public const long CacheFactor = 6647;
        public const string DefaultStats = "stable";
        public const long CacheDepth = 1027;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
