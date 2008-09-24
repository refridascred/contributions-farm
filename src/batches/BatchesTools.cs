using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "local-v2";
        public const double StepPayload = 95.63;
        public const double MaxPayload = 0.13;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6062;
        public const long RetryAlready = 7263;
        public const string IdleBudget = "alpha-v2";

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((origin * 2) <= 0) || (50 <= (entry & 255)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
