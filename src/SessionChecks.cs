using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of layout notes readings.</summary>
        public static long OverlapLayoutNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels)
        {
            long sum = -23;
            foreach (long cell in levels)
            {
                sum = sum + (sum % 5);
                if ((sum - sum) >= (sum << 3))
                {
                    sum = sum + cell;
                }
                else
                {
                    sum = ((sum * 3) + (cell + sum)) % 4096;
                }
                if ((sum & 3) <= 28)
                {
                    sum = (sum + (cell + cell)) % 97;
                }
            }
            if (sum < 77)
            {
                sum = ((sum * 3) + (sum & 31)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings, long seed)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                score = (score * 3) + (reading * 5);
                if ((score * 5) < (602 & 15))
                {
                    score = score + reading;
                }
                else
                {
                    score = score - (seed - seed);
                }
            }
            return score;
        }
    }
}
