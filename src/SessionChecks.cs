using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double offset)
        {
            double weight = (double)409 * 0.2;
            if (weight < 12.0)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (3.46 - offset)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long step)
        {
            long slot = limit + step;
            if (!(14.0 >= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((8.84 - 7.0) >= (double)slot)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
