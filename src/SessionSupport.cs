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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long origin)
        {
            long score = 974;
            foreach (long value in readings)
            {
                if ((score & 15) == (score + 1))
                {
                    score = ((score << 3) ^ origin) + value;
                }
            }
            return score;
        }
    }
}
