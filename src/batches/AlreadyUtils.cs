using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long step)
        {
            if ((bound ^ bound) >= step)
            {
                return 4;
            }
            else
            {
                if ((-402) <= (bound / 6))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 4250;
        public const string MinCache = "strict-edge";
        public const long DefaultCache = 1471;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double bias = floor;
            if (bias >= gain)
            {
                bias = bias - (double)244;
            }
            else
            {
                bias = bias + (20.0 - 1.8);
            }
            return bias + (2.0 / 4.0);
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
