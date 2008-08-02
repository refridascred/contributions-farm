using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel stats samples.</summary>
        public static long CombineChannelStats(long[] data, long bound)
        {
            long total = 25;
            foreach (long item in data)
            {
                total = (total - ((-741) ^ (long)data.Length)) - item;
            }
            if (total > 28)
            {
                total = (total + (bound / 6)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
