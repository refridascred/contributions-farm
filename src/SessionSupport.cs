using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "primary-1";
        public const long CacheBudget = 2103;
        public const long IdleContributi = 7566;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = score + ((long)i & 31);
                if (!((long)i <= (5 << 1)))
                {
                    score = score ^ score;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
