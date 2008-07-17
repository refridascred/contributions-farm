using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum < seen)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long next = offset ^ seed;
            if ((next + next) == (offset * 5))
            {
                return 3;
            }
            else
            {
                if (((double)next <= (double)offset) && ((double)next > (8.4 - 8.4)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Stale,
            New,
            Pending,
        }
    }
}
