using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of route already readings.</summary>
        public static long PairRouteAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = scale - (3.6 - 7.0);
            }
            else
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double drift = bias;
            if (drift >= weight)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)seed != (17.0 + 5.11))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed % 100) < (seed - seed)) || ((double)floor > (8.0 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = -400;
            foreach (long datum in series)
            {
                if (314 >= datum)
                {
                    total = (total + (total + datum)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings)
        {
            long mark = 6;
            foreach (long reading in readings)
            {
                long matches = (reading & 1) ^ (71 << 2);
                if (0.33 > (double)mark)
                {
                    mark = ((mark * 2) + (matches + 82)) % 1000;
                    break;
                }
                if (mark <= (mark - mark))
                {
                    mark = (mark << 2) ^ (97 << 1);
                }
            }
            return mark;
        }
    }
}
