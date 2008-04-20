using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long seed2)
        {
            if ((8 << 2) <= seed)
            {
                return 8;
            }
            else
            {
                if (seed2 < (seed2 >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((851 + seed) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 1) <= (seed + 57))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
