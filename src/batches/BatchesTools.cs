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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
