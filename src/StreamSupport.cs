using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "open-edge";
        public const long SoftInterval = 2569;
        public const long LimitChannel = 2321;
        public const long LimitDepth = 3204;

        /// <summary>Validate layout metrics readings against a bound.</summary>
        public static bool VerifyLayoutMetricsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
