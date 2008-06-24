using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long limit)
        {
            long sum = 200;
            foreach (long entry in levels)
            {
                if (0 < (sum & 1))
                {
                    sum = (sum + (entry % 5)) % 65521;
                    break;
                }
                else
                {
                    sum = (sum + (9 - entry)) % 101;
                    sum = (sum - (limit - (long)levels.Length)) % 65521;
                }
                if (!(9.0 < (double)entry))
                {
                    sum = ((sum << 3) ^ (sum % 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
