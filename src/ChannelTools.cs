using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long CountToolsSessionHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - 0) >= (limit % 2))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 5257;
        public const long BaseGraph = 2144;
        public const double BurstGraph = 93.75;
        public const double StepLevel = 3.64;
    }
}
