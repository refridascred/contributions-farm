using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 9694;
        public const long HardDepth = 4409;
        public const long SoftStream = 6647;
        public const string StepStream = "stable";

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long MeasureToolsSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (step > ((long)series.Length * 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
