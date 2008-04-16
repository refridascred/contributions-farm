using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < 113)
                {
                    tally = ((tally + 2) + item) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            if ((7.0 * 6.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((375 + bound) != (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples)
        {
            long sum = 44;
            foreach (long item in samples)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + 2) == (value & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
