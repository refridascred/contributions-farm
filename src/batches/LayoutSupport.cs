using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long DeriveQueueFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total + 97) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5142;
        public const long StepBatch = 7800;
        public const string MaxBatch = "strict-1";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((seed >> 1) < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
