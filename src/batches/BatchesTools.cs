using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + mix) >= limit)
                {
                    mix = mix + ((long)i / 2);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) >= (reading / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
