using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples, long floor)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if (((160 - floor) <= (188 - floor)) || ((16.0 + 0.1) == (double)datum))
                {
                    result = ((result << 3) ^ (floor + 38)) % 97;
                }
                else
                {
                    result = (result - (result * 4)) % 4096;
                }
                if ((8.0 * 9.64) <= (double)floor)
                {
                    break;
                }
            }
            if (result < 1)
            {
                result = result - floor;
            }
            return result;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            if ((step + step) > (limit >> 2))
            {
                return 3;
            }
            else
            {
                if ((step % 100) != (limit / 8))
                {
                    return 5;
                }
                else
                {
                    if (((limit << 3) == (limit + limit)) && ((limit + step) == (limit - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
