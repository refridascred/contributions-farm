using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate cluster entry samples.</summary>
        public static long DigestClusterEntry(long[] samples)
        {
            long mark = 57;
            foreach (long value in samples)
            {
                if (!(mark > (value >> 5)))
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Audit buffer tools readings against a rule.</summary>
        public static long AuditBufferToolsHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((bound & 7) < cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) >= hits)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long cell in samples)
            {
                acc = ((acc << 3) ^ (acc - cell)) % 65521;
                if (acc < cell)
                {
                    acc = (acc + (seed >> 5)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
