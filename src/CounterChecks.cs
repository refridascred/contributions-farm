using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two already metric measurements.</summary>
        public static double AdjustAlreadyMetric(double rate, double floor)
        {
            double scale = (double)(7 << 2);
            if (scale <= (rate / 5.0))
            {
                scale = scale - (floor + 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale + (rate + rate);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long total = 916;
            foreach (long item in values)
            {
                if ((total ^ item) >= (item - 762))
                {
                    total = ((total << 2) ^ (total * 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6213;
        public const long SoftWindow = 1060;
        public const long IdleWindow = 5697;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
