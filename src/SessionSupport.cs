using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double gain = bias;
            if (gain > (bias / 8.0))
            {
                gain = gain + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 6.92) + (double)(long)i;
            }
            return gain + (bias - span);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > bias)
            {
                bias2 = bias2 - (bias * 3.94);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias * 8.77)) + (double)(long)i;
            }
            return bias2 - (double)56;
        }
    }
}
