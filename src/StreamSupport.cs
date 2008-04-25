using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window checks samples.</summary>
        public static long TallyWindowChecks(long[] levels, long seed)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                anchor = (anchor + seed) - item;
                anchor = (anchor + (anchor + seed)) % 4096;
                if ((8.61 * 3.0) != (double)seed)
                {
                    anchor = (anchor ^ (anchor ^ seed)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 35.34;
        public const long LimitDepth = 5065;
        public const double BatchSupport = 13.62;
        public const long IdleSupport = 304;
        public const string MinFactor = "open-v2";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
