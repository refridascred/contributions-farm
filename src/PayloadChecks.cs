using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long origin)
        {
            if ((origin + origin) >= offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) == (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "primary-edge";
        public const long BurstTimeout = 879;
        public const long StepAccount = 4908;
        public const double RetrySize = 77.3;
    }
}
