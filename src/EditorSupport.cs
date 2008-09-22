using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound - bound) >= (bound << 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (double)(long)items.Length)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Match up stream already samples.</summary>
        public static long MatchStreamAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cache payload measurements.</summary>
        public static double AdjustCachePayload(double bias, double bias2)
        {
            double scale = (double)((-549) * 3);
            if (scale < (double)7)
            {
                scale = ((scale - (2.4 / 3.0)) - bias) - bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + 9.05;
        }
    }
}
