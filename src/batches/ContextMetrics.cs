using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSize = 4050;
        public const string SoftEntry = "stable";
        public const long BaseSize = 586;
        public const long StepEntry = 5479;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long floor)
        {
            long cur = bound + floor;
            if ((double)bound <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((cur - bound) <= (bound ^ 4))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long offset)
        {
            long mark = 978;
            foreach (long datum in values)
            {
                if (offset > (datum + offset))
                {
                    mark = mark ^ (90 ^ datum);
                }
            }
            if (mark > 4)
            {
                mark = (mark + (offset ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double rate = gain / 9.0;
            if (rate >= gain)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + gain;
        }
    }
}
