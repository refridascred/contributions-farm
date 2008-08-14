using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long anchor = 18;
            foreach (long sample in data)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                if (!(2.2 > (double)sample))
                {
                    break;
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 3) + (anchor - 183)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a support already figure with a bias.</summary>
        public static double AdjustSupportAlready(double ratio, double offset)
        {
            double gain = 19.0;
            if (gain > offset)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain + 4.0;
            }
            return gain - (gain + ratio);
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
