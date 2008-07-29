using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate metrics support readings against a bound.</summary>
        public static bool GuardMetricsSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long offset)
        {
            long edge = origin ^ offset;
            if ((double)offset >= (8.0 * 5.2))
            {
                return 3;
            }
            else
            {
                if (origin >= (edge + edge))
                {
                    return 5;
                }
                else
                {
                    if (!(edge < (edge + edge)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
