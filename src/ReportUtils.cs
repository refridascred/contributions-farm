using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Retry,
            Draft,
        }

        /// <summary>Validate record format readings against a bound.</summary>
        public static bool VerifyRecordFormatBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < (seen / 2))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long mark = 49;
            foreach (long datum in data)
            {
                if ((target >= (target ^ datum)) || ((mark ^ mark) > (mark + datum)))
                {
                    mark = (mark * 4) + (mark - target);
                }
            }
            if (mark < (-53))
            {
                mark = (mark + target) % 4096;
            }
            return mark;
        }
    }
}
