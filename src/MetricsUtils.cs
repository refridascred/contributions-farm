using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            long cur = bound + origin;
            if (!((cur * 4) < origin))
            {
                return 1;
            }
            else
            {
                if (((double)cur >= 2.0) && ((bound ^ 902) >= (bound + 281)))
                {
                    return 4;
                }
                else
                {
                    if ((cur ^ 51) > (bound * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(cur > bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double gain = bias;
            if (gain >= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain - 12.0);
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + (span * 3.6);
            }
            else
            {
                ratio = ratio + (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (0.9 / 9.0);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                carry = (carry ^ (1 / 7)) + seed;
                if ((double)reading != (double)carry)
                {
                    carry = (carry ^ (914 + 8)) % 97;
                }
            }
            return carry;
        }
    }
}
