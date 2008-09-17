using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long TallyQueueSchemaHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ seed) == (seed - seed))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepTimeout = 83.73;
        public const long CacheLevel = 5417;
        public const double MaxSchema = 67.86;
        public const long IdleCount = 8206;
        public const long DefaultSchema = 136;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + (-927)) > (datum / 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
