using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Locked,
            Done,
            Active,
            New,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    total = ((total ^ limit) % 101) - (long)i3;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxScore = "stable";
        public const long LimitSpan = 3671;
        public const long BurstChecks = 6527;
        public const long SoftChecks = 2790;
        public const double MaxChecks = 18.83;
    }
}
