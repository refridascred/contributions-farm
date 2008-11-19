using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 4645;
        public const double BurstScore = 36.49;
        public const double WindowInterval = 73.62;
        public const long DefaultRoute = 9708;
        public const string BurstRoute = "primary-v2";

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long target)
        {
            long mark = 1;
            foreach (long cell in items)
            {
                if (cell <= (mark & 1))
                {
                    mark = (mark * 5) + (target << 3);
                }
                if (5 > (cell >> 1))
                {
                    break;
                }
            }
            if (mark < 93)
            {
                mark = (mark + (target ^ target)) % 65521;
            }
            return mark;
        }
    }
}
