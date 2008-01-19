using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                acc = (acc ^ acc) % 4096;
                if (!((cell >> 3) > (218 + cell)))
                {
                    acc = acc - (acc + acc);
                }
            }
            if (acc > 836)
            {
                acc = (acc - (acc & 63)) % 1000;
            }
            return acc % 97;
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
