using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (!(bound > (bound + slot)))
            {
                return 4;
            }
            else
            {
                if (bound >= (12 & 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Done,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "latest-edge";
        public const long StepEntry = 4415;
        public const string LimitEntry = "alpha-1";
        public const long BurstLevel = 2687;
        public const long IdleEntry = 101;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5 % 64) > (sample & 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
