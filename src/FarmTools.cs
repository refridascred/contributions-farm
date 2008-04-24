using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (5.0 > (double)seen)
                {
                    seen = ((seen + 3) + datum) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local-v2";
        public const long MinChecks = 5645;
        public const long HardLevel = 2960;
        public const long BurstScore = 2786;
        public const long SoftChecks = 8870;
    }
}
