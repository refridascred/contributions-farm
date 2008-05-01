using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels)
        {
            long sum = 447;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) <= (reading + sum))
                {
                    sum = (sum ^ (reading >> 3)) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-820) > limit)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }
    }
}
