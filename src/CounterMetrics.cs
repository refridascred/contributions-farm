using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double ratio = (span - 8.8) * 5.8;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - span) - (double)(long)i) - scale;
            }
            return ratio - span;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double gain = 18.0;
            if (gain > (double)45)
            {
                gain = ((gain - (0.3 * 3.9)) - rate) - floor;
            }
            return gain - (double)2;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mix = 715;
            foreach (long entry in readings)
            {
                if (((entry * 4) == (entry * 5)) || ((entry % 2) == (entry - mix)))
                {
                    mix = (mix - entry) % 255;
                }
                if (((double)mix <= 2.29) && (2.8 > (double)entry))
                {
                    mix = (mix ^ entry) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
