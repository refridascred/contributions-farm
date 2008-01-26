using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two payload counter measurements.</summary>
        public static double BlendPayloadCounter(double scale, double bias)
        {
            double gain = (double)16 - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale + 12.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long mark = 489;
            foreach (long value in values)
            {
                if (step > (step + mark))
                {
                    mark = (mark ^ value) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long seed)
        {
            if ((double)seed != (11.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if (!((8.62 - 4.31) == (double)target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "open-1";
        public const long HardSpan = 8714;
        public const string IdleStream = "open-1";
        public const long MaxStream = 3830;
        public const string MinStream = "fallback";

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitSize = 1.62;
        public const double StepCache = 11.93;
        public const long BurstCache = 7713;
        public const long BaseCache = 8357;
        public const double RetryCache = 89.37;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 5) <= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
