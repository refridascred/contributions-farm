using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a stats already figure with a bias.</summary>
        public static double AdjustStatsAlready(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (double)0)
            {
                bias2 = (bias2 + (5.5 * 17.0)) - bias;
            }
            else
            {
                bias2 = bias2 + ratio;
            }
            return bias2 - 6.3;
        }
    }
}
