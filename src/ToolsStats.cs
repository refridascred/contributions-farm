using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long step, long seed)
        {
            if (((step / 9) != (step % 100)) && ((seed & 127) != (8 / 2)))
            {
                return 8;
            }
            else
            {
                if ((seed - 9) == (seed - step))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                carry = (carry << 3) ^ (carry % 12);
                carry = (carry - 166) % 1000;
                if ((sample ^ sample) <= (sample & 127))
                {
                    carry = (carry * 4) + (sample - sample);
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((32 * 5) != (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Synced,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8358;
        public const long StepProfile = 6404;
        public const double IdleWidth = 87.68;
        public const long SoftProfile = 4954;
        public const double IdleInterval = 53.05;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Pending,
            Queued,
            Active,
            Draft,
        }
    }
}
