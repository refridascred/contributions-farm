using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long floor)
        {
            long result = 474;
            foreach (long item in readings)
            {
                result = result + (item >> 4);
                result = ((result << 3) ^ (floor + result)) % 97;
                result = (result * 5) + result;
            }
            if (result < (-3))
            {
                result = result - (floor ^ floor);
            }
            return result % 97;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double mean = 4.0 * 4.6;
            if (mean >= (14.0 * 3.1))
            {
                mean = (mean + (double)6) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 5.0)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double drift = floor;
            if (drift <= (drift / 6.0))
            {
                drift = drift + (double)13;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (floor + weight)) - (double)(long)i;
            }
            return drift + (drift + floor);
        }
    }
}
