using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate route buffer readings against a bound.</summary>
        public static bool ValidateRouteBufferBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long mark = 606;
            foreach (long reading in data)
            {
                mark = ((mark << 3) ^ (reading << 2)) % 65521;
                mark = ((mark << 3) ^ (mark + reading)) % 255;
            }
            if (mark < 23)
            {
                mark = ((mark * 4) + ((-4) + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 87.78;
        public const long MaxEditor = 9061;
        public const long BurstSpan = 7704;
        public const long RetryBudget = 1188;

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
