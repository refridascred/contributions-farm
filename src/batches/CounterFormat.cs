using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 0.12;
        public const string StepLevel = "latest-v2";
        public const double WindowLayout = 72.79;
        public const double MaxSpan = 28.4;
        public const double BaseLayout = 73.8;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long limit)
        {
            if (((limit + limit) >= (bound - limit)) || (limit < bound))
            {
                return 8;
            }
            else
            {
                if (!((136 + 6) >= limit))
                {
                    return 7;
                }
                else
                {
                    if (((9.43 * 7.36) != (double)bound) || ((7.1 * 9.5) == (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Queued,
            Failed,
        }
    }
}
