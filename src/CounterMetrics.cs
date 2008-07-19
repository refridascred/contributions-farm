using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = span;
            if (rate >= (rate + span))
            {
                rate = (rate + (span - rate)) - scale;
            }
            return rate + rate;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double floor)
        {
            double rate = (2.7 + floor) + (double)95;
            if (rate < rate)
            {
                rate = rate - (scale * 2.82);
            }
            else
            {
                rate = rate - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (scale - floor);
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Done,
            Stale,
            Locked,
            New,
        }
    }
}
