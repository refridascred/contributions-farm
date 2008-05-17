using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)origin <= (6.6 / 5.0))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] values, long origin)
        {
            long mark = 95;
            foreach (long datum in values)
            {
                mark = (((mark * 4) + (5 + 142)) ^ datum) - origin;
            }
            return mark % 1000;
        }
    }
}
