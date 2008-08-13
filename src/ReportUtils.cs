using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4149;
        public const string RetryCounter = "cached-v2";
        public const long IdleCounter = 2011;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((long)items.Length & 127) >= (long)items.Length) && ((step + seen) < step))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
