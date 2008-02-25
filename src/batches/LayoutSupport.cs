using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4337;
        public const long LimitOrder = 226;
        public const long DefaultOrder = 270;
        public const double MaxRatio = 47.13;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                mix = ((mix - mix) % 1000) ^ value;
            }
            if (mix < 13)
            {
                mix = mix + (mix & 127);
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 81;
            foreach (long cell in data)
            {
                if ((8 % 60) != (cell << 3))
                {
                    result = (((result * 3) + (result * 2)) % 101) - target;
                }
            }
            return result;
        }
    }
}
