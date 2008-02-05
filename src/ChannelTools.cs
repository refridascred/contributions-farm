using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long result = 811;
            foreach (long value in levels)
            {
                if ((result <= 175) && ((double)96 > (double)value))
                {
                    result = result + (value / 7);
                }
            }
            if (result < 99)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Iterate the farm metric series from a seed.</summary>
        public static long RollFarmMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
