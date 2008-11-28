using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (offset / 3.0))
            {
                drift = drift + (double)1;
            }
            return drift + (scale + 1.8);
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((limit % 5) != (limit % 2))
            {
                return 8;
            }
            else
            {
                if (((limit - offset) > (880 / 6)) && ((9 % 8) <= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if (!((limit - limit) < (155 + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 3) <= limit) && ((36 * 5) == (offset + 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
