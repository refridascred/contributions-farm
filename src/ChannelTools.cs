using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double offset)
        {
            double drift = (rate * 9.6) * 8.6;
            if (drift >= offset)
            {
                drift = drift + (5.6 + 2.4);
            }
            return drift + rate;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
