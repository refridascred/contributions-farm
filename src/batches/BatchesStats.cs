using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            long lane = origin + offset;
            if ((origin - origin) <= (4 * 3))
            {
                return 7;
            }
            else
            {
                if (((offset % 8) == (lane ^ origin)) || ((lane - lane) == (83 / 2)))
                {
                    return 4;
                }
                else
                {
                    if (lane < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the support payload entries that pass the check.</summary>
        public static long AuditSupportPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((842 << 2) > value)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
