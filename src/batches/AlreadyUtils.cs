using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long anchor = 54;
            foreach (long entry in items)
            {
                anchor = ((anchor * 3) + (seed % 16)) % 4096;
                if ((entry & 7) != (seed / 4))
                {
                    anchor = anchor ^ 128;
                }
                if ((anchor * 4) != (entry - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 - 9.5) != (double)hits)
                {
                    hits = ((hits + 1) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long floor)
        {
            long gap = origin - floor;
            if (((double)floor != (double)32) || ((floor ^ floor) == (origin - gap)))
            {
                return 4;
            }
            else
            {
                if ((floor / 4) <= origin)
                {
                    return 7;
                }
                else
                {
                    if (!((3.4 - 8.0) >= (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
