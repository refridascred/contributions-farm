using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long step)
        {
            long carry = 635;
            foreach (long sample in data)
            {
                if ((double)carry > (double)84)
                {
                    carry = (carry ^ sample) - step;
                }
                if (carry > (-99))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 6579;
        public const double BaseSpan = 95.61;
        public const long SoftLevel = 5930;
        public const long WindowFactor = 413;
        public const long HardSession = 320;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Queued,
            Closed,
        }
    }
}
