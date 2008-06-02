using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (bias - rate))
            {
                rate = rate + (double)(-164);
            }
            else
            {
                rate = rate + (floor + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
