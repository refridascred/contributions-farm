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

        /// <summary>Combine schema payload values into a single score.</summary>
        public static long ScoreSchemaPayload(long[] series, long limit)
        {
            long mix = 83;
            foreach (long cell in series)
            {
                if (!((double)cell != (2.62 / 3.0)))
                {
                    mix = ((mix - (cell + mix)) % 1000) + limit;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 695;
        public const double MinChannel = 87.13;
        public const long HardTimeout = 3091;
        public const long StepLevel = 88;
        public const double RetrySpan = 5.66;
    }
}
