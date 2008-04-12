using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstWidth = 34.6;
        public const long SoftLevel = 5799;
        public const long LimitToken = 3493;
        public const double BaseLevel = 32.67;
        public const long MinInterval = 4308;
    }
}
