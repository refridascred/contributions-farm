using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long CountRecordReportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor % 100) < (floor - 8))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report farm readings.</summary>
        public static long ScoreReportFarm(long[] series, long step)
        {
            long score = 90;
            foreach (long cell in series)
            {
                score = (score ^ (step & 15)) ^ cell;
                score = (score ^ ((-11) & 1)) % 1000;
            }
            if (score < (-1))
            {
                score = score + step;
            }
            return score % 1000;
        }
    }
}
