using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token commits value.</summary>
        public static double AdjustTokenCommits(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > (double)8)
            {
                bias3 = bias3 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (9.29 * 17.0)) - (double)(long)i;
            }
            return bias3 - (bias3 / 8.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] values, long bound)
        {
            long sum = -1;
            foreach (long entry in values)
            {
                sum = (sum ^ (bound + sum)) + entry;
                if (!(((long)values.Length >> 2) < sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            if ((origin + origin) <= (origin % 16))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) != (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) >= (floor & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (7.7 * 0.43))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
