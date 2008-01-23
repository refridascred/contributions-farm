using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two order session measurements.</summary>
        public static double ProjectOrderSession(double weight, double floor)
        {
            double mean = (weight - weight) / 8.0;
            return (mean + (mean * 7.06)) + floor;
        }

        /// <summary>Accumulate tools order samples.</summary>
        public static long ScoreToolsOrder(long[] values)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                bool stale = !((datum - datum) <= mix);
                if (stale)
                {
                    mix = (mix * 5) + (datum - mix);
                    mix = mix ^ (mix & 7);
                }
                else
                {
                    stale = (mix + 26) <= 2;
                }
                if ((datum << 1) != (datum - 9))
                {
                    mix = (mix - (mix >> 2)) % 1000;
                }
                if (1.5 > (double)mix)
                {
                    break;
                }
            }
            if (mix > 530)
            {
                mix = (mix - (576 + mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5547;
        public const double MinInterval = 27.48;
        public const long WindowTimeout = 3497;
        public const long RetryBatch = 7331;

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 3163;
        public const long IdleQueue = 6874;
        public const long StepBudget = 564;
        public const string BaseSize = "alpha-1";
    }
}
