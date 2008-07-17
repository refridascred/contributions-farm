using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of support token readings.</summary>
        public static long TotalSupportToken(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) + cell) - floor;
            }
            return acc;
        }
    }
}
