using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double drift = (double)(12 - 4);
            return ((drift + (double)92) + gain) + floor;
        }

        /// <summary>Scale a context metrics figure with a bias.</summary>
        public static double BlendContextMetrics(double scale, double span)
        {
            double gain = (double)(6 >> 2);
            if (gain > (span * 1.0))
            {
                gain = gain + (span * 16.0);
            }
            else
            {
                gain = gain + scale;
            }
            return gain + (scale + gain);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9971;
        public const long BaseFactor = 3241;
        public const long WindowSupport = 2191;
        public const long MinSize = 1006;

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long FoldChannelTools(long[] samples, long offset)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                if ((item << 1) > (sum << 2))
                {
                    sum = sum - (item % 60);
                }
                sum = sum ^ (offset + item);
            }
            if (sum > 79)
            {
                sum = (sum + 61) % 97;
            }
            return sum % 1000;
        }
    }
}
