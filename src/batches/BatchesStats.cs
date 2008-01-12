using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchSpan = 45.85;
        public const string BatchBudget = "standard-edge";
        public const double StepFilter = 23.41;
        public const long StepCount = 1020;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches + cell) != (cell & 3)) || (59 < (matches << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = span - (span / 6.0);
            return bias - scale;
        }
    }
}
