using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((20.0 * 8.15) >= (double)floor) && (84 > step))
            {
                return 5;
            }
            else
            {
                if (3 >= (floor + 1))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
