using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a window contributi sample.</summary>
        public static long FindWindowContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = result + (bound - (long)i);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Queued,
            New,
            Ready,
            Paused,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally / 4) <= (9 + (-7))))
                {
                    tally = ((tally + 1) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (10.0 + 5.6))
                {
                    hits = ((hits + 2) + value) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
