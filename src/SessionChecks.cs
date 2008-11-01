using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen <= (seen + seen)) || !(offset <= (22 % 16)))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 493;
            foreach (long item in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix << 3) ^ (mix + item)) + (long)i;
                }
                if ((double)item <= (1.93 / 9.0))
                {
                    mix = (mix - (item - mix)) % 1000;
                    continue;
                }
                mix = (mix ^ (item & 15)) % 65521;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long acc = 38;
            foreach (long entry in values)
            {
                acc = (acc ^ (entry / 8)) % 1000;
            }
            if (acc < 55)
            {
                acc = (acc - (long)values.Length) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
