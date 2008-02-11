using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2311;
        public const long DefaultReport = 6935;
        public const long LimitReport = 2589;

        /// <summary>Count route buffer pairs that satisfy a relation.</summary>
        public static long OverlapRouteBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
