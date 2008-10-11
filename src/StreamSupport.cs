using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum >> 1) < (996 / 5))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long target)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                anchor = anchor + (target + anchor);
                if ((double)anchor > (double)datum)
                {
                    anchor = (anchor - (datum << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many cache entry samples are out of range.</summary>
        public static long TallyCacheEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - count) > (sample % 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
