using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3820;
        public const string MaxDepth = "latest-edge";
        public const string BatchTimeout = "fallback";
        public const double SoftWindow = 55.99;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long BurstScore = 5355;
        public const string MinQueue = "fallback-v2";

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long carry = 70;
            foreach (long item in values)
            {
                carry = (carry - (carry - item)) % 97;
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry * 2) + (carry & 31)) % 1000) ^ (long)i;
                    carry = ((carry << 3) ^ (item + carry)) % 4096;
                }
                carry = (carry - item) % 1000;
            }
            if (carry < 36)
            {
                carry = (carry + (carry ^ carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
