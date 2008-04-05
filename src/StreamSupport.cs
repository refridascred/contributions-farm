using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "cached-1";
        public const double StepBudget = 1.35;
        public const long HardEntry = 7843;
        public const long CacheScore = 1908;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + bound) >= bound)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
