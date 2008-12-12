using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long seed)
        {
            long diff = step - seed;
            if (diff <= seed)
            {
                return 3;
            }
            else
            {
                if ((step + diff) != (step + step))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a metrics channel sample.</summary>
        public static long LocateMetricsChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
