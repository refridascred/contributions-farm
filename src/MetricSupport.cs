using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long target)
        {
            if ((target * 3) > (693 % 7))
            {
                return 0;
            }
            else
            {
                if ((14.0 / 4.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) != (22 % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double bias)
        {
            double mean = (bias + bias) / 6.0;
            if (mean > rate)
            {
                mean = mean + (mean * 7.16);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
