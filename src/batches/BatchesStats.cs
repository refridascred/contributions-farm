using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 19.12;
        public const long IdleDepth = 3446;
        public const string BatchBatches = "alpha-edge";
        public const long MaxDepth = 8622;
        public const double RetryFactor = 52.61;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long mix = 430;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (long)i) % 255;
                }
                mix = mix - (datum - mix);
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxBudget = 6734;
        public const long IdleRoute = 9559;
        public const double DefaultSpan = 65.32;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long result = -3;
            foreach (long sample in series)
            {
                result = ((((result << 3) ^ result) % 65521) ^ sample) + floor;
            }
            return result;
        }
    }
}
