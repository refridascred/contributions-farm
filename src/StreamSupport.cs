using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long offset)
        {
            if (!((limit << 2) <= limit))
            {
                return 5;
            }
            else
            {
                if ((limit >> 2) != (15 + limit))
                {
                    return 0;
                }
                else
                {
                    if (((7 + 46) >= (offset / 3)) && ((46 - limit) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
