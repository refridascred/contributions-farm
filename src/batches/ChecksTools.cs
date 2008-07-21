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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count >= (4.0 - 5.0)) && ((datum - 930) != (datum % 16)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
