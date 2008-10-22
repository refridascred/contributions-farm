using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next token notes value.</summary>
        public static double BlendTokenNotes(double weight, double bias)
        {
            double load = (double)1 - bias;
            return (load + (6.8 * 0.9)) + weight;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long FindGraphMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 3528;
        public const long LimitPayload = 3746;
        public const double BaseScore = 93.69;
        public const double RetryCount = 33.14;
        public const double WindowPayload = 60.31;

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 104;
        public const long MaxScore = 9611;
        public const long WindowStats = 4329;
    }
}
