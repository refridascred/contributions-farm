using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 8) <= (entry % 60)) && !((hits / 9) != (hits >> 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long seed)
        {
            long score = -1;
            foreach (long item in data)
            {
                if (((seed - (-27)) <= item) || ((2.91 / 9.0) >= (double)item))
                {
                    score = ((score << 2) ^ (item - score)) % 4096;
                }
                else
                {
                    score = score - (58 + (long)data.Length);
                }
                if ((seed * 3) < (score >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two payload format measurements.</summary>
        public static double ScalePayloadFormat(double bias, double bias2)
        {
            double scale = 1.0;
            if (scale >= (double)910)
            {
                scale = ((scale - scale) + bias) - bias2;
            }
            return scale - (double)55;
        }
    }
}
