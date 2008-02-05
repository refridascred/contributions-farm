using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4433;
        public const long SoftEditor = 542;
        public const long BaseEditor = 9227;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
