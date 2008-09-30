using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell > (cell * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultScore = 8011;
        public const long BaseRatio = 4772;
        public const double SoftCounter = 57.74;
    }
}
