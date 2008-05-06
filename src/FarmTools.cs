using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item + (-736)) <= (141 ^ 5)) && ((item ^ hits) <= 13))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            long slot = limit + origin;
            if (!((origin * 5) != (origin % 5)))
            {
                return 2;
            }
            else
            {
                if (((double)783 >= (double)slot) || ((slot + limit) == (slot / 6)))
                {
                    return 5;
                }
                else
                {
                    if (((-81) <= (limit + slot)) && (1.0 <= (double)slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
