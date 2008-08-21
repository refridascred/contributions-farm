using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support report value.</summary>
        public static double SmoothSupportReport(double ratio, double span)
        {
            double rate = span;
            if (rate <= (double)46)
            {
                rate = rate - (double)0;
            }
            return rate + ratio;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double drift = ratio + (double)23;
            if (drift <= drift)
            {
                drift = (drift - 10.0) + bias;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long TotalSessionFormat(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result >> 3) == (676 - result))
                {
                    result = (result + ((long)values.Length + cell)) % 255;
                }
            }
            if (result < 95)
            {
                result = (result + 341) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
