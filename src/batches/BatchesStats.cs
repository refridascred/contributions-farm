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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long origin)
        {
            if (((6.73 / 2.0) != (double)step) && ((step + origin) == (origin + origin)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= 8.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin * 2) >= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
