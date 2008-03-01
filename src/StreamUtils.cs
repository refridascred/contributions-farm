using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next support command value from a seed.</summary>
        public static long SeriesSupportCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 1208;
        public const long MinScore = 2129;
        public const double BurstBudget = 77.38;
    }
}
