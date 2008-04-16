using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 48;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + (long)i)) % 97;
                    carry = (carry + (cell + cell)) % 1000;
                }
                carry = carry ^ carry;
            }
            if (carry > 12)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchInterval = 6274;
        public const string StepTimeout = "primary-edge";
        public const long BatchFactor = 6824;
        public const long IdleSpan = 1452;
        public const string BaseRatio = "legacy-1";
    }
}
