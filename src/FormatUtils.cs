using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long AuditFilterAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 97) >= seen)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long floor)
        {
            long total = -54;
            foreach (long datum in data)
            {
                total = ((total * 3) + (datum >> 4)) % 97;
            }
            if (total > 832)
            {
                total = total + floor;
            }
            return total % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
