using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(count > (floor / 9)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (((datum * 2) > (score + datum)) && ((double)datum == (7.0 + 2.1)))
                {
                    score = score + (datum + score);
                }
                else
                {
                    score = (score << 2) ^ (datum * 2);
                }
            }
            return score % 97;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry - (bound * 2)) ^ (long)i2;
                }
                carry = ((carry * 4) + (bound ^ bound)) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
