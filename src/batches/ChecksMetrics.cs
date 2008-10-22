using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double AdjustAccountBatch(double bias, double span)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = rate + bias;
            }
            return rate + span;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long seed)
        {
            if (((seed + 35) <= (seed / 5)) && ((double)floor <= (10.0 / 3.0)))
            {
                return 3;
            }
            else
            {
                if ((floor & 3) > (580 << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) < (seed + floor)) || ((3.1 + 2.56) <= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.0 / 6.0) != (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metrics cluster pair into a bucket.</summary>
        public static long BucketMetricsCluster(long floor, long target)
        {
            if (target >= (floor & 7))
            {
                return 0;
            }
            else
            {
                if ((5.4 / 3.0) != (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((4 + 91) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double mean = (bias / 6.0) - (double)932;
            if (mean < 0.6)
            {
                mean = (mean + (bias + bias)) + weight;
            }
            else
            {
                mean = mean + (bias / 6.0);
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Fold a list of batches layout readings.</summary>
        public static long FoldBatchesLayout(long[] samples)
        {
            long score = 7;
            foreach (long datum in samples)
            {
                score = (score - (2 & 15)) - datum;
            }
            return score % 1000;
        }
    }
}
