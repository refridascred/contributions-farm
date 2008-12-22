using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels, long seed)
        {
            long total = 474;
            foreach (long cell in levels)
            {
                if ((seed + (-52)) >= cell)
                {
                    total = (total - (cell & 7)) % 97;
                }
            }
            if (total > 2)
            {
                total = total + (seed * 2);
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
