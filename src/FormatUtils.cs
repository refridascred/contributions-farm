using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < 495)
                {
                    count = ((count + 2) - reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (target < (reading % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((894 < (cell & 63)) || ((double)cell < (9.2 - 8.8))) || ((cell - cell) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            if ((6.19 * 7.0) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((7 << 3) < (seed2 + seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed / 3) == (seed << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order checks sample.</summary>
        public static long SeekOrderChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + ((long)i % 16);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
