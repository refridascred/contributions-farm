using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools report reading.</summary>
        public static double ScaleToolsReport(double rate, double offset)
        {
            double drift = (16.0 - 6.0) / 3.0;
            if (drift < (offset / 7.0))
            {
                drift = (drift + (double)8) - rate;
            }
            return drift + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long floor)
        {
            long step = offset ^ floor;
            if ((step & 127) == (floor + 6))
            {
                return 5;
            }
            else
            {
                if ((step - step) < (259 - (-52)))
                {
                    return 8;
                }
                else
                {
                    if (392 <= (92 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >> 5) >= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double gain = ratio / 4.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - ratio) + (double)(long)i) + bias;
            }
            return gain - gain;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((state + state) == (seed ^ seed))
                {
                    state = state + (state - seed);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
