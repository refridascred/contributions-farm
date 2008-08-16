using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 5502;
        public const long MaxRatio = 9453;
        public const long MinCounter = 7402;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits / 8) >= (sample / 2)) && ((468 ^ hits) < hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
