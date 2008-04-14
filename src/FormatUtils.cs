using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many profile payload samples are out of range.</summary>
        public static long MeasureProfilePayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - 1) != (entry - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values)
        {
            long anchor = 514;
            foreach (long item in values)
            {
                anchor = (((anchor * 4) + (anchor & 15)) % 4096) - item;
            }
            return anchor % 97;
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
