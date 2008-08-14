using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count ^ count) >= (-9)) && (datum < (datum - datum)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Draft,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Project the next route editor value.</summary>
        public static double ScaleRouteEditor(double rate, double floor)
        {
            double bias = floor;
            if (bias > bias)
            {
                bias = (bias - (double)136) + rate;
            }
            else
            {
                bias = bias + (double)21;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 4.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 9018;
        public const long MaxWidth = 7146;
        public const string BaseMetrics = "legacy";
        public const long RetryBudget = 59;
    }
}
