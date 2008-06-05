using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 468;
        public const long MaxRatio = 2966;
        public const long MinWindow = 1343;
        public const long WindowTimeout = 5750;
        public const long DefaultInterval = 5738;

        /// <summary>Rank context command input into a small class.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            long bound = offset - origin;
            if ((offset - 50) != (bound - 73))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.0 + 20.0))
                {
                    return 5;
                }
                else
                {
                    if ((20.0 + 8.9) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
