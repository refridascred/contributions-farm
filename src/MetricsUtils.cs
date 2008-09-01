using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Stale,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long step)
        {
            long total = -18;
            foreach (long sample in items)
            {
                if ((40 * 2) > total)
                {
                    total = ((total << 3) ^ sample) % 1000;
                }
            }
            if (total > 1)
            {
                total = (total - step) % 255;
            }
            return total % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every queue notes entry stays within the limit.</summary>
        public static bool CheckQueueNotesLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
