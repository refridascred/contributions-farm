using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long sum = 3;
            foreach (long item in data)
            {
                sum = ((sum * 3) + (852 - sum)) % 65521;
                if ((4 > (sum ^ 5)) && ((item >> 5) >= 76))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9558;
        public const string BurstFarm = "primary-1";
        public const long BaseFactor = 9180;
        public const long SoftFarm = 3440;
        public const long MaxRatio = 5222;
    }
}
