using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long seed)
        {
            long delta = offset + seed;
            if (4.0 > (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= (delta % 24))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a filter githubfarm sample.</summary>
        public static long SeekFilterGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
