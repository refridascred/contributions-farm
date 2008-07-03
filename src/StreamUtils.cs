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

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long state = 57;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 101;
                state = (state - state) % 1000;
                if (19.0 <= (double)datum)
                {
                    state = state + (state >> 2);
                }
            }
            if (state < 3)
            {
                state = (state - state) % 255;
            }
            return state;
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
