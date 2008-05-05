using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "standard-v2";
        public const double BatchDepth = 24.2;
        public const double MaxDepth = 58.53;
        public const long WindowCount = 8721;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long bound, long offset)
        {
            long bound2 = bound - offset;
            if (((0.04 * 0.1) <= (double)bound2) || ((12.0 * 9.19) != (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((double)bound2 >= (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((4.42 + 7.0) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (6.07 < (double)(long)data.Length)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)seed < (double)828) || (cell > (seed - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
