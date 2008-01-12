using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate channel graph samples.</summary>
        public static long ScoreChannelGraph(long[] data)
        {
            long mark = -135;
            foreach (long entry in data)
            {
                mark = (mark - entry) % 101;
            }
            return mark;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double ratio2 = bias / 8.0;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 + 3.0) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (bias - bias);
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double load = (9.0 / 8.0) * 4.15;
            return ((load + (load - load)) + rate) + offset;
        }
    }
}
