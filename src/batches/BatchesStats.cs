using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long bound)
        {
            long diff = offset ^ bound;
            if (!(offset < (bound / 8)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ offset) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((diff & 127) > (5 + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 73.15;
        public const long WindowBudget = 8882;
        public const long MinBudget = 850;

        /// <summary>Measure how many tools profile samples are out of range.</summary>
        public static long MeasureToolsProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen + value) <= (value + 972)) || ((value % 97) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Dropped,
            Draft,
        }
    }
}
