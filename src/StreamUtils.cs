using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Synced,
            Stale,
            New,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series)
        {
            long acc = 72;
            foreach (long sample in series)
            {
                if ((0.3 - 8.1) != (double)acc)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 4096) - sample;
                }
                acc = ((acc * 2) + (acc + acc)) % 97;
            }
            if (acc < (-36))
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((double)limit2 <= (11.0 + 16.0))
            {
                return 3;
            }
            else
            {
                if ((1.02 / 5.0) > (double)slot)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
