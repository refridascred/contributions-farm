using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
