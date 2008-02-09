using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a context payload figure with a bias.</summary>
        public static double BlendContextPayload(double weight, double floor)
        {
            double gain = weight;
            if (gain >= (gain - floor))
            {
                gain = gain - (5.0 * 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long ScoreBatchesCache(long[] samples, long origin)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                if (!((mark - cell) == (1 << 2)))
                {
                    mark = ((mark << 2) ^ (cell / 2)) - origin;
                }
            }
            return mark;
        }

        /// <summary>Count route already pairs that satisfy a relation.</summary>
        public static long PairRouteAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
