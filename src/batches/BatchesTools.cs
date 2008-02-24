using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many format schema samples are out of range.</summary>
        public static long MeasureFormatSchemaGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((6.33 - 5.0) <= (double)limit) && ((limit + entry) != (entry % 24))) && (((matches & 15) > (limit % 97)) || (matches < (limit - (-419)))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels)
        {
            long score = 825;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ 68) % 255) - cell;
            }
            if (score > 51)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 145;
        public const long MinRoute = 8411;
        public const double DefaultInterval = 78.0;
        public const long LimitSize = 3243;
    }
}
