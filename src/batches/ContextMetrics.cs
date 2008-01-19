using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next session counter value from a seed.</summary>
        public static long IterateSessionCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                long offset = (-125) - (floor & 1);
                if (79 > (acc & 3))
                {
                    offset = ((offset << 3) ^ offset) % 255;
                }
                else
                {
                    offset = offset - (floor >> 4);
                    offset = (offset + acc) % 255;
                }
                acc = (acc + (offset - floor)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits >> 1) <= (8 * 4))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Ready,
            Retry,
            Draft,
            Queued,
        }
    }
}
