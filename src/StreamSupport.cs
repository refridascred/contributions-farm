using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                if ((mix ^ limit) < (mix % 10))
                {
                    mix = ((mix << 3) ^ 5) % 101;
                }
                if ((double)value < (11.0 * 10.0))
                {
                    mix = (mix - (limit % 97)) % 65521;
                }
                mix = ((mix << 2) ^ limit) % 97;
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools route reading.</summary>
        public static double SmoothToolsRoute(double weight, double floor)
        {
            double drift = 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift - weight)) + (double)(long)i) + floor;
            }
            return drift + drift;
        }
    }
}
