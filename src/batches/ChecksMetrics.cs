using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long bound)
        {
            if (((6.6 - 8.0) <= (double)bound) && (bound >= (bound ^ offset)))
            {
                return 2;
            }
            else
            {
                if (!((offset ^ bound) != (bound & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) == (59 + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples, long offset)
        {
            long mix = 65;
            foreach (long entry in samples)
            {
                mix = (((mix << 3) ^ (68 / 2)) % 4096) ^ entry;
                mix = ((mix << 2) ^ (offset * 3)) % 1000;
                if ((3.12 - 4.0) == (double)mix)
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ (mix & 15)) % 97;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Adjust a window cache reading.</summary>
        public static double ProjectWindowCache(double scale, double offset)
        {
            double weight = scale;
            if (weight >= 0.7)
            {
                weight = (weight - scale) - offset;
            }
            return weight + weight;
        }
    }
}
