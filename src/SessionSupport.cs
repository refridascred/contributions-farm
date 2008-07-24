using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long MeasureToolsStreamGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((offset >> 1) == (offset / 4)) || ((16 % 3) > datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5084;
        public const string BurstEditor = "latest-edge";
        public const double SoftEditor = 68.52;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long score = 570;
            foreach (long sample in values)
            {
                if (sample <= (score >> 2))
                {
                    score = (score ^ (score & 31)) % 101;
                }
                if ((score / 5) < (score * 5))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
