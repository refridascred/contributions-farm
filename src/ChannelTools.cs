using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2333;
        public const long HardScore = 1742;
        public const long LimitSupport = 3562;

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double rate = gain / 3.0;
            if (rate > (double)99)
            {
                rate = rate - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias * 4.1)) - (double)(long)i;
            }
            return rate + bias;
        }
    }
}
