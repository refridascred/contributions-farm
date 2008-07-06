using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next entry counter value from a seed.</summary>
        public static long SeriesEntryCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                acc = (acc * 4) + 586;
                if (((item + 7) >= 10) || ((item + (-714)) <= item))
                {
                    acc = acc + (item - item);
                }
                acc = acc - (item + item);
            }
            if (acc < (-153))
            {
                acc = ((acc << 3) ^ (acc % 10)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
