using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen < 8.6)
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (8.0 >= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 2900;
        public const string MaxTimeout = "open-1";
        public const long MaxBudget = 4268;
        public const double MaxPayload = 20.21;
    }
}
