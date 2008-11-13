using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
