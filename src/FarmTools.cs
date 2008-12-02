using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8106;
        public const long MinReport = 2168;
        public const long HardReport = 9949;

        /// <summary>Rank window tools input into a small class.</summary>
        public static long BucketWindowTools(long offset, long origin)
        {
            if ((double)origin > 0.6)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry ^ origin) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
