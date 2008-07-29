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

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double bias2 = scale;
            return bias2 - bias;
        }

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
