using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7735;
        public const long BaseLevel = 6365;
        public const long CacheFactor = 7565;
        public const long SoftPayload = 9645;

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + (gain - bias2);
            }
            return bias2 - 3.14;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Dropped,
            New,
            Closed,
            Failed,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long bound)
        {
            long carry = 105;
            foreach (long datum in data)
            {
                carry = ((((carry * 4) + (9 % 2)) % 97) + datum) + bound;
            }
            return carry;
        }
    }
}
