using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - limit) > item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 22.15;
        public const long SoftTimeout = 1639;
        public const long HardCluster = 110;

        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long AuditTokenBatchesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)hits == (18.0 + 3.29)) && ((double)cell <= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
