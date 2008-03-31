using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Combine schema payload values into a single score.</summary>
        public static long ScoreSchemaPayload(long[] series, long limit)
        {
            long mix = 83;
            foreach (long cell in series)
            {
                if (!((double)cell != (2.62 / 3.0)))
                {
                    mix = ((mix - (cell + mix)) % 1000) + limit;
                }
            }
            return mix;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            New,
            Pending,
            Retry,
        }
    }
}
