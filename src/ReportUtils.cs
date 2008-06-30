using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                acc = acc + cell;
                if ((cell - floor) <= (floor ^ acc))
                {
                    acc = (acc - (acc - cell)) % 65521;
                }
            }
            if (acc < 72)
            {
                acc = acc + (floor ^ floor);
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8520;
        public const string BurstFactor = "alpha";
        public const long RetryRoute = 938;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 237;
            foreach (long cell in data)
            {
                total = ((total * 3) + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Failed,
            Active,
            Ready,
            Closed,
        }
    }
}
