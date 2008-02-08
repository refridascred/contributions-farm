using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleTimeout = 8397;
        public const double StepOrder = 93.55;
        public const long MaxLevel = 23;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Closed,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] items, long offset)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 2) + (item - (-98));
            }
            if (sum > 74)
            {
                sum = ((sum * 5) + (sum ^ offset)) % 4096;
            }
            return sum % 1000;
        }
    }
}
