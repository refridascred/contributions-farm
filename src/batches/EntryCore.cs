using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 73;
            foreach (long cell in values)
            {
                if (((3.58 * 4.49) > (double)cell) && (387 <= sum))
                {
                    long offset2 = (offset - sum) / 2;
                    sum = ((sum * 2) + offset2) % 101;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (cell + cell);
                    sum = ((sum * 5) + (offset + cell)) % 4096;
                }
                if (offset > (offset / 9))
                {
                    sum = (sum - (sum + offset)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((double)reading == (0.1 * 3.0)) || ((double)matches != (5.7 - 5.3))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster token entries.</summary>
        public static long CombineClusterToken(long[] values, long origin)
        {
            long score = 67;
            foreach (long sample in values)
            {
                if (((origin / 7) != (score << 1)) && ((sample << 2) > (origin >> 2)))
                {
                    score = score ^ (sample >> 1);
                    score = (score - (sample << 1)) % 1000;
                }
                if ((origin << 2) != (origin << 3))
                {
                    score = (score ^ (score * 2)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
