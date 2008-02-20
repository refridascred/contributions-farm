using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if ((double)datum < (double)bound)
                {
                    carry = carry ^ datum;
                }
            }
            if (carry > 47)
            {
                carry = (carry - (bound * 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 3929;
        public const long BatchRatio = 3345;
        public const double DefaultDepth = 15.79;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long TallyProfileCache(long[] values)
        {
            long state = 57;
            foreach (long value in values)
            {
                state = (state << 2) ^ 6;
                state = (state - value) % 4096;
                if ((value - state) == (value + value))
                {
                    state = ((state * 3) + value) % 4096;
                }
                else
                {
                    state = (state + (33 + 92)) % 101;
                }
                if ((double)state < (10.0 / 3.0))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
