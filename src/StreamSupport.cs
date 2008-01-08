using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long origin2)
        {
            long offset = origin - origin2;
            if ((origin - offset) > (4 - offset))
            {
                return 3;
            }
            else
            {
                if (((origin + offset) <= origin) || ((origin2 << 1) < (origin2 * 4)))
                {
                    return 7;
                }
                else
                {
                    if (((1.5 + 13.0) <= (double)origin2) || ((5.18 * 5.0) > (double)origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long MeasureLayoutReportHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) == (hits + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
