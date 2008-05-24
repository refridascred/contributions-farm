using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of filter order readings.</summary>
        public static long MatchFilterOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support filter readings.</summary>
        public static long WeighSupportFilter(long[] values, long offset)
        {
            long state = 34;
            foreach (long datum in values)
            {
                state = ((state + (64 >> 5)) % 97) - datum;
                state = ((state << 3) ^ (offset * 3)) % 255;
            }
            if (state < 700)
            {
                state = (state - (state & 7)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7059;
        public const long SoftCount = 4797;
        public const long CacheBudget = 9987;
        public const long BurstFilter = 849;
        public const long RetryScore = 8338;
    }
}
