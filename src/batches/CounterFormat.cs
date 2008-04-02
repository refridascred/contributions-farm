using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((1.8 - 7.0) <= (double)count)
                {
                    count = ((count + 2) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }
    }
}
