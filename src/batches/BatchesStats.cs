using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (80 >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 5574;
        public const long StepFactor = 5819;
        public const string MaxTimeout = "strict";
        public const long BaseRatio = 773;
        public const long DefaultGraph = 6564;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
