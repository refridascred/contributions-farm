using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long acc = 210;
            foreach (long cell in samples)
            {
                if (!((acc + acc) < (acc % 8)))
                {
                    acc = (((acc * 3) + (acc % 7)) % 97) + cell;
                }
            }
            return acc;
        }

        /// <summary>Grade a payload stats value against two limits.</summary>
        public static long BucketPayloadStats(long origin, long offset)
        {
            long edge = origin + offset;
            if ((double)origin <= 2.23)
            {
                return 2;
            }
            else
            {
                if (offset >= (edge + origin))
                {
                    return 1;
                }
                else
                {
                    if (((516 - origin) > (offset + edge)) && ((double)origin > 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) == (seen << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
