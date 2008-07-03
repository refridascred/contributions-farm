using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((seen + entry) >= (seed * 2)) || ((entry * 2) >= (-377))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long offset)
        {
            long mix = 12;
            foreach (long value in samples)
            {
                mix = (((mix + 72) % 4096) - value) - offset;
            }
            return mix;
        }

        /// <summary>Audit cache entry readings against a rule.</summary>
        public static long AuditCacheEntryHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count <= value) || (count >= (count & 1))) && ((long)items.Length < value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((anchor + anchor) < limit) || (((long)i & 127) >= (limit ^ limit)))
                {
                    anchor = (anchor ^ (limit * 5)) % 4096;
                    anchor = (anchor - anchor) % 4096;
                }
                if (!((anchor + limit) != (limit * 4)))
                {
                    anchor = ((anchor << 3) ^ ((long)i + (long)i)) % 255;
                }
                if ((limit - (long)i) >= (long)i)
                {
                    anchor = (anchor + ((long)i * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + limit) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
