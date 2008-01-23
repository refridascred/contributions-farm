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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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
