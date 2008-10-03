using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches >> 3) > (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double bias = (rate * 6.4) - rate;
            if (bias >= (bias / 4.0))
            {
                bias = bias + 8.36;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (floor - floor)) + (double)(long)i;
            }
            return bias - 3.77;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > weight)
            {
                weight2 = (weight2 - weight2) - span;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + 6.97) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long delta = (568 & 255) + step;
                    state = (((state * 5) + delta) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
