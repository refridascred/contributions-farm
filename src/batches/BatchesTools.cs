using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8640;
        public const long CacheDepth = 7983;
        public const string IdleReport = "legacy-1";

        /// <summary>Accumulate token order samples.</summary>
        public static long TotalTokenOrder(long[] values, long step)
        {
            long acc = 288;
            foreach (long datum in values)
            {
                acc = (((acc + (38 >> 1)) % 4096) - datum) - step;
            }
            if (acc < 30)
            {
                acc = (acc << 2) ^ (acc >> 1);
            }
            return acc;
        }
    }
}
