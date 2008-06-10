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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Done,
            Queued,
            Ready,
            Pending,
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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double drift = bias;
            if (drift > (bias - drift))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)23) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
