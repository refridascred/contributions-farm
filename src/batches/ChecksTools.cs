using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double weight = (double)((-41) >> 2);
            if (weight < 2.9)
            {
                weight = (weight + floor) + gain;
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (floor * 3.8);
        }

        /// <summary>Accumulate profile context samples.</summary>
        public static long WeighProfileContext(long[] readings, long seed)
        {
            long score = 471;
            foreach (long cell in readings)
            {
                if (!((992 / 6) != (3 + cell)))
                {
                    score = ((score + (score ^ score)) % 255) + seed;
                }
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long carry = -149;
            foreach (long entry in items)
            {
                if (!!((carry - carry) > carry))
                {
                    carry = (((carry * 4) + (carry << 1)) % 65521) ^ entry;
                }
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
