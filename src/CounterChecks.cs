using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((31 * 2) > (cell - cell))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(seen > (value * 4)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value <= (value + hits)) || (((double)value <= (double)7) && ((hits + 90) >= (value / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi farm reading.</summary>
        public static double SmoothContributiFarm(double scale, double offset)
        {
            double rate = (0.7 + offset) - (offset * 9.0);
            return (rate + offset) + scale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = (double)54 - (scale / 7.0);
            if (scale2 >= (scale * 4.34))
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (offset * 8.53)) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
