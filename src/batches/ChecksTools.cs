using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a metrics command figure with a bias.</summary>
        public static double AdjustMetricsCommand(double ratio, double bias)
        {
            double scale = (bias * 0.9) / 6.0;
            if (scale > bias)
            {
                scale = (scale - (double)4) - ratio;
            }
            return scale - scale;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
