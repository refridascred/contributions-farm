using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc > (offset >> 4))
                {
                    acc = ((acc * 5) + (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 90.58;
        public const double StepFactor = 59.88;
        public const double IdleGraph = 57.73;
        public const double HardGraph = 5.08;
        public const long MaxScore = 3319;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double rate = 6.9;
            if (rate >= (floor / 8.0))
            {
                rate = rate + 7.0;
            }
            else
            {
                rate = rate + (8.7 / 9.0);
            }
            return rate - weight;
        }
    }
}
