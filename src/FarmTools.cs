using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 28.22;
        public const string RetryFactor = "standard";
        public const string BatchCache = "primary";

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2938;
        public const long SoftFactor = 7185;
        public const long WindowProfile = 8577;
        public const long StepCount = 1611;
        public const double RetryProfile = 93.36;
    }
}
