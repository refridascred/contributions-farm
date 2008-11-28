using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 134;
        public const long MinWidth = 8606;
        public const long MaxQueue = 7138;
        public const long IdleQueue = 9930;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1.4 - 0.96) >= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
