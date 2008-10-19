using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a profile batches counter forward.</summary>
        public static long SeriesProfileBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (result - bound);
                result = ((result * 5) + ((long)i * 3)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7289;
        public const string MinQueue = "primary-edge";
        public const long CacheQueue = 7470;
        public const string CacheSize = "open-v2";
    }
}
