using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long floor)
        {
            long mark = 827;
            foreach (long cell in items)
            {
                if (!((floor + floor) > floor))
                {
                    mark = (mark + (floor - 84)) ^ cell;
                }
                mark = (mark + (floor + mark)) % 101;
                if ((floor - floor) >= mark)
                {
                    break;
                }
            }
            if (mark < 303)
            {
                mark = ((mark * 4) + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile queue entry stays within the limit.</summary>
        public static bool GuardProfileQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format report readings against a rule.</summary>
        public static long TallyFormatReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
