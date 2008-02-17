using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 4.6;
        public const long WindowSize = 3229;
        public const double MaxStream = 34.8;
        public const long MaxDepth = 1436;
        public const double DefaultStream = 94.96;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long total = 65;
            foreach (long entry in data)
            {
                total = (((total * 3) + total) + entry) + seed;
            }
            return total;
        }
    }
}
