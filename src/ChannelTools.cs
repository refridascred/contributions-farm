using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 440;
        public const string StepDepth = "standard-edge";
        public const long SoftTools = 7;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step >= (sample - hits))
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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Stale,
            Draft,
            Retry,
        }
    }
}
