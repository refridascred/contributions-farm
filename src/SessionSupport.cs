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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double ratio = (gain / 4.0) * 8.52;
            if (ratio < gain)
            {
                ratio = (ratio - gain) - floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + 10.0;
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
