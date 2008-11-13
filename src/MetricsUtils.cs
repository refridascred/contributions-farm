using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((floor - (long)samples.Length) != (tally - 1)) && (((floor * 2) <= (floor ^ tally)) && (tally > (tally * 5))))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9998;
        public const long RetryCluster = 1842;
        public const long RetryLevel = 3840;

        /// <summary>Accumulate session schema samples.</summary>
        public static long TotalSessionSchema(long[] data, long target)
        {
            long sum = 7;
            foreach (long entry in data)
            {
                sum = (sum + (target >> 1)) ^ entry;
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((650 * 3) < (946 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
