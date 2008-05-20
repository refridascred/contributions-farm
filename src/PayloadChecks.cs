using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double rate = (ratio * 8.6) - (floor + ratio);
            if (rate < (floor - 16.0))
            {
                rate = rate - (19.0 * 7.2);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.56 + floor)) + (double)(long)i;
            }
            return rate - (12.0 - floor);
        }

        /// <summary>Look up the position of a support counter sample.</summary>
        public static long SeekSupportCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache metric readings.</summary>
        public static long TotalCacheMetric(long[] series)
        {
            long mix = -1;
            foreach (long sample in series)
            {
                mix = mix + (sample & 1);
                if ((mix - sample) >= (sample + sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double ratio = (double)(5 % 60);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (ratio + offset)) + (double)(long)i) + scale;
            }
            return ratio + offset;
        }
    }
}
