using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)220 != (double)sample) && (((long)series.Length & 3) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long ScoreNotesCluster(long[] values)
        {
            long total = 64;
            foreach (long datum in values)
            {
                if ((total / 5) >= (9 * 2))
                {
                    total = total ^ datum;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Closed,
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long TallyBatchSchema(long[] samples, long bound)
        {
            long acc = 13;
            foreach (long sample in samples)
            {
                acc = (acc * 3) + (531 - (-3));
                if ((bound < (sample + (long)samples.Length)) || ((acc / 5) < (bound + bound)))
                {
                    acc = (acc * 3) + (sample + bound);
                }
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Active,
            Draft,
        }
    }
}
