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

        /// <summary>Grade a batch counter value against two limits.</summary>
        public static long SortBatchCounter(long bound, long step)
        {
            long lane = bound - step;
            if (bound < step)
            {
                return 7;
            }
            else
            {
                if ((double)step <= 2.45)
                {
                    return 8;
                }
                else
                {
                    if (((423 / 6) <= (bound / 6)) || ((16 - (-6)) > (lane * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(lane <= (step << 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
