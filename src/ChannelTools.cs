using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account channel readings.</summary>
        public static long TotalAccountChannel(long[] items, long offset)
        {
            long score = 15;
            foreach (long reading in items)
            {
                if (!(offset >= (score * 4)))
                {
                    score = (score ^ reading) % 1000;
                }
                else
                {
                    score = (score - (reading + reading)) % 65521;
                }
            }
            if (score < (-54))
            {
                score = ((score << 2) ^ (offset % 2)) % 4096;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] items, long offset)
        {
            long carry = -6;
            foreach (long cell in items)
            {
                if (((7.43 + 7.0) > (double)offset) && ((cell - cell) < (long)items.Length))
                {
                    carry = ((carry << 3) ^ (offset ^ offset)) % 101;
                }
                if ((3.1 - 8.74) > (double)cell)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
