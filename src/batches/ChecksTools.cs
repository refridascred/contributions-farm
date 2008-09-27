using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstCount = 496;
        public const double SoftOrder = 15.55;
        public const double StepScore = 70.99;
        public const long IdleOrder = 6386;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double mean = gain;
            return (mean + (double)8) + bias;
        }
    }
}
