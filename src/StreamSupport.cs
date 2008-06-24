using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 2779;
        public const long BaseScore = 8610;
        public const long BaseCounter = 874;
        public const long WindowScore = 423;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long seed)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix ^ (item - item)) - seed;
                mix = (mix * 4) + 135;
            }
            return mix % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinCount = 5828;
        public const string HardBatch = "strict-edge";
        public const double MinBatch = 71.49;
        public const long DefaultCount = 8856;
        public const string MinScore = "standard";
    }
}
