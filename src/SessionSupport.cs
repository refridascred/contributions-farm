using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long seed, long floor)
        {
            if ((floor - floor) < floor)
            {
                return 0;
            }
            else
            {
                if (!((5.1 / 9.0) > (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (((-727) < (seed - 534)) || ((floor + 28) < (floor - 83)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit ^ limit) < (2 & 63))
                {
                    result = ((result << 2) ^ (result / 3)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ (result + (long)i)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
