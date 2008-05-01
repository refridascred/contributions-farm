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

        /// <summary>Accumulate filter token samples.</summary>
        public static long FoldFilterToken(long[] data, long bound)
        {
            long sum = 370;
            foreach (long sample in data)
            {
                if ((bound >> 4) >= bound)
                {
                    sum = ((sum - (bound * 2)) % 65521) ^ sample;
                }
                else
                {
                    sum = ((sum * 4) + (8 + sum)) % 65521;
                }
            }
            return sum;
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
