using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits < (double)reading) && ((hits / 9) < 490))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long state = 848;
            foreach (long value in levels)
            {
                if ((limit * 4) > limit)
                {
                    state = (state - limit) % 65521;
                }
                if ((value - (long)levels.Length) >= (state + 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-v2";
        public const long IdleMetric = 4859;
        public const double WindowInterval = 14.41;
        public const long MinWidth = 6786;
    }
}
