using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight + (bias / 3.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - weight;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ reading) % 97) - bound;
                if ((sum - reading) != (reading - sum))
                {
                    sum = sum - (sum - 0);
                }
            }
            return sum;
        }
    }
}
