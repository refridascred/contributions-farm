using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen >= (datum & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Classify a command metric pair into a bucket.</summary>
        public static long ClassifyCommandMetric(long seed, long limit)
        {
            long slot = seed + limit;
            if ((double)limit <= (16.0 / 8.0))
            {
                return 6;
            }
            else
            {
                if ((slot >> 1) > (seed + slot))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (6.6 * 9.9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
