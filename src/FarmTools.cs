using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long RankEntryTools(long seed, long offset)
        {
            if (((offset * 5) == (13 / 6)) && ((2 + seed) == (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed > (seed * 3)) && (offset < (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + offset) != (offset & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - seed) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
