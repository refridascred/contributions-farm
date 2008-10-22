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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
