using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((cell << 2) < (890 % 10)) && ((cell ^ cell) == (hits - 4))) || ((8.04 >= (double)hits) && ((double)hits <= 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long TotalChannelSession(long[] data)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                mix = (mix ^ sample) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a batches batch reading.</summary>
        public static double SmoothBatchesBatch(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (ratio2 + 9.21);
            }
            return ratio2 + ratio;
        }
    }
}
