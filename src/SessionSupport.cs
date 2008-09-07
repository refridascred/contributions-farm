using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 9477;
        public const double WindowFactor = 19.83;
        public const double MaxEntry = 93.81;
        public const double BaseBudget = 4.88;
        public const long BurstRatio = 4735;

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long IterateBatchesAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((result & 31) < (63 / 5))
                {
                    result = (result * 4) + bound;
                }
                else
                {
                    result = ((result * 3) + bound) % 255;
                    result = result + (bound / 3);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
