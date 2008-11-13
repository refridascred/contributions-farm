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

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool VerifyCounterPayloadLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
