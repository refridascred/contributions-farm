using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 8047;
        public const long LimitDepth = 1727;
        public const long MinLayout = 566;
        public const long LimitLevel = 4164;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                carry = carry - (datum + carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Idle,
            New,
            Ready,
        }
    }
}
