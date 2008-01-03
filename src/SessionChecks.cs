using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((offset - offset) < (offset + offset)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long limit)
        {
            long acc = 93;
            foreach (long cell in items)
            {
                if (!((double)cell == (18.0 - 7.0)))
                {
                    acc = (acc + (cell >> 4)) + limit;
                }
                else
                {
                    acc = ((acc * 5) + (cell % 3)) % 97;
                }
            }
            if (acc < 97)
            {
                acc = acc ^ (acc & 7);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 220;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length > 9.47))
                {
                    total = (((total << 2) ^ (total << 1)) % 101) + entry;
                }
                total = ((total << 2) ^ (8 / 9)) % 4096;
            }
            if (total < 3)
            {
                total = (total - (total << 3)) % 97;
            }
            return total % 97;
        }

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long TallyLayoutSupportHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) == (0 - reading))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
