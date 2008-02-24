using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long seed)
        {
            long delta = floor + seed;
            if (delta <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 - seed))
                {
                    return 3;
                }
                else
                {
                    if (7 > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                if ((2.01 / 3.0) >= (double)entry)
                {
                    mark = mark - (entry % 5);
                }
                else
                {
                    mark = ((mark << 3) ^ offset) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3813;
        public const long BatchTimeout = 2381;
        public const string BatchNotes = "open-edge";
    }
}
