using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseDepth = 3571;
        public const string LimitWidth = "fallback-v2";
        public const long LimitBuffer = 5954;
        public const long IdleBuffer = 3226;
        public const long DefaultBuffer = 1011;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((value ^ value) > (limit - 713)) && ((86 * 2) >= (matches + 46))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items)
        {
            long mix = 327;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ (reading * 4)) + (long)i;
                }
                mix = (mix ^ (mix % 3)) % 1000;
            }
            return mix % 4096;
        }
    }
}
