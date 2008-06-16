using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long bound)
        {
            if ((seed >> 2) > seed)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
