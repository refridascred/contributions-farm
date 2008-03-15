using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batches profile entries.</summary>
        public static long WeighBatchesProfile(long[] series, long floor)
        {
            long anchor = -128;
            foreach (long datum in series)
            {
                if (((anchor - floor) >= (datum + floor)) || ((double)floor >= (5.0 + 5.28)))
                {
                    anchor = ((anchor * 2) + (floor << 3)) % 4096;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (floor << 2)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 46.23;
        public const double BaseEntry = 19.23;
        public const long DefaultSpan = 3556;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 42.1;
        public const double IdleGraph = 93.51;
        public const string HardScore = "strict-v2";
    }
}
