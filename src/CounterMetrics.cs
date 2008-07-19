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

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (floor * 5.49)) - rate;
            }
            else
            {
                drift = drift + (floor / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift + 7.22;
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
