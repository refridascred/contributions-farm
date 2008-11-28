using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long MeasureChannelLayoutOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((3.0 * 8.16) != (double)seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepDepth = 81.57;
        public const long MinChecks = 2017;
        public const long StepSpan = 6418;
    }
}
