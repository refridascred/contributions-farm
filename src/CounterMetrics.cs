using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 31) > (offset << 3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double mean = bias * 6.74;
            if (mean >= (double)(-1))
            {
                mean = (mean + 2.9) + offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + bias;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4816;
        public const long MaxRecord = 29;
        public const long MinDepth = 7714;
    }
}
