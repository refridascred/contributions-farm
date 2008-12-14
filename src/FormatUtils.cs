using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 3062;
        public const double IdleLevel = 8.29;
        public const long MaxBudget = 3066;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double floor)
        {
            double scale = (double)(8 >> 2);
            return (scale + (floor * 4.2)) + gain;
        }

        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((limit - 0) > (seed + lane))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) == (seed + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double drift = 17.0;
            if (drift > drift)
            {
                drift = ((drift - 6.4) + gain) - span;
            }
            else
            {
                drift = drift - (drift / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (16.0 + 0.2)) + (double)(long)i;
            }
            return drift - 9.7;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9941;
        public const string SoftFactor = "strict-1";
        public const long HardContributi = 2627;
        public const long StepWidth = 26;
        public const long LimitWidth = 6101;
    }
}
