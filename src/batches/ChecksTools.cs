using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((317 >> 5) != (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload cluster value against two limits.</summary>
        public static long SortPayloadCluster(long origin, long floor)
        {
            if (floor <= (89 - floor))
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) == (11 - origin)) && ((origin << 1) < (origin % 3)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 * 18.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long TallyGraphTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((6.23 - 2.8) < (double)item)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
