using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batch queue series from a seed.</summary>
        public static long DeriveBatchQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total * 5) + total;
                if (((total + 11) < floor) && ((4.0 / 3.0) <= (double)total))
                {
                    total = (total * 2) + (337 - floor);
                    total = total - (total + floor);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double bias = (double)(-8) - span;
            if (bias < (span / 8.0))
            {
                bias = (bias + 2.56) - gain;
            }
            else
            {
                bias = bias + (9.67 - bias);
            }
            return bias + (bias * 0.18);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "cached";
        public const long WindowNotes = 4414;
        public const long WindowBudget = 2405;
        public const long IdleCount = 978;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Closed,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain - span))
            {
                drift = drift - (span / 5.0);
            }
            else
            {
                drift = drift - 7.56;
            }
            return drift - drift;
        }
    }
}
