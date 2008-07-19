using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate buffer cluster readings against a bound.</summary>
        public static bool GuardBufferClusterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long seed)
        {
            long delta = limit - seed;
            if (((double)limit > 6.4) && ((double)limit <= (3.0 - 13.0)))
            {
                return 7;
            }
            else
            {
                if ((double)delta < (3.0 - 8.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed - seed) != (seed % 10)) || ((4 / 2) <= (limit - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
