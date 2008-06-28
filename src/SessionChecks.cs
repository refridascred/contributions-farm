using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema cluster input into a small class.</summary>
        public static long GradeSchemaCluster(long target, long step)
        {
            long step2 = target ^ step;
            if ((285 & 127) <= (target / 9))
            {
                return 0;
            }
            else
            {
                if (step2 >= (6 & 7))
                {
                    return 5;
                }
                else
                {
                    if (1.44 > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) <= (33 << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long TallyFormatBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((seed < (entry >> 4)) || ((seed >> 3) <= ((-13) ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
