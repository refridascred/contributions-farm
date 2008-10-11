using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 3391;
        public const long LimitStats = 2630;
        public const string CacheStats = "fallback-1";

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double mean = weight;
            return (mean - (mean - 7.07)) + offset;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            if (origin <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if (9.05 >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 2) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
