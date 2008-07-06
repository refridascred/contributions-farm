using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((bound - seen) > seen) && ((cell - 972) == (seen ^ 704)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
