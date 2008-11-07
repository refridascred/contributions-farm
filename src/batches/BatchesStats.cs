using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Stale,
            Draft,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long floor2)
        {
            if ((double)16 >= (double)floor2)
            {
                return 7;
            }
            else
            {
                if (floor > (floor % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((8 + 64) <= (floor2 & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((3.2 * 0.9) == (double)origin)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
