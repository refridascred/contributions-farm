using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                total = ((total * 5) + total) % 101;
                total = total + (datum + datum);
            }
            return total % 65521;
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
