using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 4891;
        public const long MinSchema = 2720;
        public const double IdleSchema = 5.33;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches < (6.0 + 9.1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
