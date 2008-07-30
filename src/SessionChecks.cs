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

        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long RollContextMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ ((long)i & 3)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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
