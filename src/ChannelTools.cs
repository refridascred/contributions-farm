using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((0.44 / 2.0) >= (double)slot)
            {
                return 3;
            }
            else
            {
                if ((bound >= (slot * 3)) && (slot < (floor + 2)))
                {
                    return 8;
                }
                else
                {
                    if (bound < slot)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + floor) == (floor - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long mark = 243;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark - (seed - mark)) % 4096) ^ (long)i) ^ sample;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark * 4) + (mark >> 3)) + (long)i2;
                }
                mark = ((mark << 2) ^ (8 + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
