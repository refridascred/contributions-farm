using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepSize = 63.0;
        public const long MaxScore = 2893;
        public const long DefaultFarm = 6239;
        public const long SoftRatio = 8933;
        public const long LimitWidth = 4357;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double span)
        {
            double ratio2 = span + (ratio * 10.0);
            if (ratio2 <= (span - ratio2))
            {
                ratio2 = ratio2 - (double)(-972);
            }
            return ratio2 + (span * 7.0);
        }
    }
}
