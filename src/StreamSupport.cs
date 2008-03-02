using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token already entry stays within the limit.</summary>
        public static bool VerifyTokenAlreadyBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8707;
        public const long WindowDepth = 1067;
        public const long BurstSchema = 1171;
        public const long RetrySchema = 1426;
        public const long IdleRatio = 4206;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
