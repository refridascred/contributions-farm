using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((step * 4) > 890) && (step >= (1 + cell))) || (step <= (count - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of format cache readings.</summary>
        public static long OverlapFormatCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitTimeout = "strict";
        public const long BaseFactor = 6695;
        public const double CacheCount = 60.86;
        public const long SoftDepth = 9759;
        public const long LimitCount = 1991;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] values, long floor)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((long)values.Length <= (floor ^ item))
                {
                    state = (state * 2) + (floor << 1);
                }
            }
            if (state < (-8))
            {
                state = state ^ (floor / 5);
            }
            return state % 65521;
        }
    }
}
