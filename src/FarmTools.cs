using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate notes context samples.</summary>
        public static long TotalNotesContext(long[] samples, long limit)
        {
            long total = 221;
            foreach (long value in samples)
            {
                if ((total + total) >= (value - limit))
                {
                    total = (total ^ (value * 2)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total * 4) + (limit >> 2);
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 695;
        public const double MinChannel = 87.13;
        public const long HardTimeout = 3091;
        public const long StepLevel = 88;
        public const double RetrySpan = 5.66;
    }
}
