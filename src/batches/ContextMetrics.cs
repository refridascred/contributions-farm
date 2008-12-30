using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stream tools reading.</summary>
        public static double AdjustStreamTools(double rate, double floor)
        {
            double bias = 5.14;
            if (bias < (rate / 5.0))
            {
                bias = (bias + (rate / 7.0)) - floor;
            }
            return bias - (rate / 7.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long state = 556;
            foreach (long cell in values)
            {
                if ((double)offset == (double)cell)
                {
                    state = (state * 3) + offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double bias = rate;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + (double)(-537);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (bias + bias);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
