using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
