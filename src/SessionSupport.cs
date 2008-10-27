using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRatio = "open-1";
        public const long HardRoute = 3458;
        public const long StepRoute = 5918;
        public const double WindowRoute = 8.55;
        public const long SoftRoute = 1935;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long total = 73;
            foreach (long item in series)
            {
                if ((6 % 3) != (total & 31))
                {
                    total = ((total + (total & 15)) % 4096) - item;
                }
            }
            return total;
        }
    }
}
