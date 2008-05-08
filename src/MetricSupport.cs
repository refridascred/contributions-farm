using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format counter values into a single score.</summary>
        public static long ScoreFormatCounter(long[] items, long bound)
        {
            long score = 45;
            foreach (long cell in items)
            {
                score = score + (bound + 7);
                if (((double)score > 6.2) && ((cell / 6) <= (cell / 8)))
                {
                    score = ((score * 4) + (score + cell)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (bound / 8);
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = (8.7 * 1.76) + (bias * 1.73);
            if (gain > (bias * 4.78))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (gain * 0.39);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
