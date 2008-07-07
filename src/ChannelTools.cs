using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchScore = 66.35;
        public const long LimitChecks = 465;
        public const long MaxWidth = 4667;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                if ((3.15 / 9.0) >= (double)value)
                {
                    anchor = (anchor - (25 % 2)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (value ^ anchor)) % 4096;
                }
                if ((double)anchor > 8.0)
                {
                    break;
                }
            }
            if (anchor < (-97))
            {
                anchor = (anchor + 6) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long score = 89;
            foreach (long cell in values)
            {
                if ((score + limit) > cell)
                {
                    score = ((score * 5) + (cell ^ limit)) % 4096;
                }
                else
                {
                    score = (score - (cell - limit)) % 101;
                }
            }
            return score;
        }
    }
}
