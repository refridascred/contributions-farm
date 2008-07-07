using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long target)
        {
            long mix = 673;
            foreach (long item in samples)
            {
                if (14.0 < (double)target)
                {
                    mix = ((mix - (mix >> 1)) % 101) + item;
                }
                if (((-3) & 31) < (target / 9))
                {
                    break;
                }
            }
            if (mix > 953)
            {
                mix = ((mix * 4) + (target - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((6 / 9) > (hits - hits))
                {
                    hits = ((hits + 1) + value) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Closed,
            Paused,
        }
    }
}
