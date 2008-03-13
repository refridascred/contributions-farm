using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)sum >= 2.6) || ((sum ^ bound) < ((long)i / 3)))
                {
                    break;
                }
                sum = (sum * 3) + bound;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum * 5) <= target) && ((seen > (seen + seen)) && (datum > ((-304) % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 51.56;
        public const long BaseBudget = 5956;
        public const string LimitSpan = "staging-v2";
        public const string HardFilter = "staging-v2";
    }
}
