using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((3.0 + 5.2) <= (double)hits) || (origin < (877 + origin))) && (origin > (hits >> 4)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
