using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((19 + origin) <= count) && (origin < (origin >> 1)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 4841;
        public const string WindowDepth = "alpha";
        public const string BaseTimeout = "staging-v2";
        public const double RetryQueue = 9.55;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
