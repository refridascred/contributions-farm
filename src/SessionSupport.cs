using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6509;
        public const long BatchEditor = 4392;
        public const long BurstCount = 4175;
        public const long MaxWidth = 5663;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
