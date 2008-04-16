using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count >> 1) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long ScoreRecordNotes(long[] values)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = acc + (acc * 2);
                if (((long)values.Length > (reading + 8)) || ((acc - acc) <= (reading + reading)))
                {
                    acc = ((acc * 2) + (281 - reading)) % 255;
                }
                else
                {
                    acc = (acc ^ (reading - acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches + matches) >= (value & 63)) || (((value * 4) <= matches) && ((value + value) <= (5 / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already route value from a seed.</summary>
        public static long RollAlreadyRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = (score * 4) + (352 - score);
                if (((long)i & 63) != (limit << 1))
                {
                    score = (score ^ (score + 253)) % 255;
                }
                score = ((score * 5) + (score + score)) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long FoldContextToken(long[] series, long offset)
        {
            long carry = 57;
            foreach (long item in series)
            {
                if (carry > (offset / 9))
                {
                    carry = ((carry << 3) ^ (item ^ item)) % 101;
                }
            }
            return carry;
        }
    }
}
