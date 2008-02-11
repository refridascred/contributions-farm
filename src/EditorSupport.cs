using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
