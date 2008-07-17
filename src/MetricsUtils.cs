using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= (double)5)
            {
                bias3 = bias3 + (double)3;
            }
            else
            {
                bias3 = bias3 + (4.7 + bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 + bias) - (double)(long)i;
            }
            return bias3 + (5.13 / 6.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ seen) == (86 % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (double)(775 ^ 5);
            if (scale < offset)
            {
                scale = scale - (offset * 1.24);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (gain * 4.05)) + (double)(long)i;
            }
            return scale - (6.0 - gain);
        }
    }
}
