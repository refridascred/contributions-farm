using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = (carry - (54 - (long)i)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally / 7) > (tally / 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 76.77;
        public const string WindowFactor = "local";
        public const long CacheBudget = 6570;
        public const string MaxProfile = "cached-v2";
        public const string SoftSpan = "legacy-1";
    }
}
