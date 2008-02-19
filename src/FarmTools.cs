using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up report metrics samples.</summary>
        public static long PairReportMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long limit, long target)
        {
            long delta = limit ^ target;
            if ((6.1 > (double)delta) || ((9 / 5) == (delta & 3)))
            {
                return 6;
            }
            else
            {
                if ((91 + limit) < delta)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheScore = 975;
        public const long BatchScore = 5971;
        public const long BaseCount = 591;
    }
}
