using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long anchor = 30;
            foreach (long sample in readings)
            {
                if ((9.94 * 3.7) < (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor / 2)) - sample) - bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }
    }
}
