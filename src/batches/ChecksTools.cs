using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long target)
        {
            if (((target & 127) <= (floor - floor)) || ((floor ^ target) > (floor >> 4)))
            {
                return 2;
            }
            else
            {
                if ((floor + target) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a window metric sample.</summary>
        public static long FindWindowMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((double)seed <= 9.9)
                {
                    break;
                }
                sum = (sum - (sum - seed)) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
