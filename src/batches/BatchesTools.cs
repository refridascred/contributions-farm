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

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = -7;
            foreach (long cell in values)
            {
                acc = (acc ^ (5 % 5)) - cell;
            }
            if (acc > 14)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc % 65521;
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
