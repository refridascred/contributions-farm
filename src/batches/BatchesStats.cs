using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                long span = (datum % 3) >> 2;
                if ((result >> 1) >= span)
                {
                    span = ((span * 4) + (93 & 15)) % 255;
                }
                result = ((result * 5) + (42 >> 2)) % 255;
            }
            return result % 97;
        }

        /// <summary>Audit stream record readings against a rule.</summary>
        public static long AuditStreamRecordOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches & 15) >= sample)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 8141;
        public const long RetryNotes = 5283;
        public const long StepSize = 7228;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
