using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheFactor = 93.03;
        public const long IdleBatch = 830;
        public const double MinBatch = 28.28;
        public const double BatchTimeout = 91.4;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + 5) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long offset)
        {
            long mix = -364;
            foreach (long sample in readings)
            {
                if ((double)sample <= (5.07 - 13.0))
                {
                    mix = (mix + (sample >> 2)) % 101;
                }
                mix = ((mix * 2) + (offset + offset)) % 97;
            }
            return mix;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double AdjustCommitsWindow(double gain, double floor)
        {
            double mean = (double)((-9) >> 2);
            if (mean < mean)
            {
                mean = mean + (gain / 2.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = result + (result >> 3);
                result = result + (result + step);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
