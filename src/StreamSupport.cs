using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 7000;
        public const string BurstBudget = "open-v2";
        public const double RetrySpan = 83.56;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long step)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                mark = ((mark * 4) + (step - step)) % 255;
                if (((long)items.Length > step) && ((cell * 4) >= (step - cell)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Done,
            Pending,
        }
    }
}
