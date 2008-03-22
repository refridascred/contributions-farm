using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long CountGraphRouteOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((29 - tally) != (bound & 63)) && (reading < (long)series.Length)) && ((169 / 6) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank commits support input into a small class.</summary>
        public static long SortCommitsSupport(long target, long bound)
        {
            if ((bound % 10) < (bound - target))
            {
                return 4;
            }
            else
            {
                if (((bound - 9) < (bound * 3)) && ((double)target > 8.03))
                {
                    return 3;
                }
                else
                {
                    if ((0 / 7) < (bound & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 5999;
        public const long IdleReport = 786;
        public const double DefaultReport = 25.34;
    }
}
