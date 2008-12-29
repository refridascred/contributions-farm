using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long step)
        {
            long state = -97;
            foreach (long entry in levels)
            {
                state = (state + step) + entry;
            }
            if (state > 361)
            {
                state = ((state * 4) + (state >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
