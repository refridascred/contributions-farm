using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first order farm entry that matches the target.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1770;
        public const long RetryChannel = 423;
        public const string BaseChannel = "staging-edge";

        /// <summary>Check that every payload tools entry stays within the limit.</summary>
        public static bool VerifyPayloadToolsRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
