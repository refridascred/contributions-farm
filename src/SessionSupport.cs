using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ (long)i) ^ (long)i2;
                    carry = (carry + (carry + step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] levels, long limit)
        {
            long score = -60;
            foreach (long datum in levels)
            {
                if ((double)limit >= (2.16 - 2.6))
                {
                    score = (((score << 2) ^ (score - score)) % 97) ^ datum;
                }
            }
            if (score < 752)
            {
                score = ((score * 2) + (420 * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = anchor ^ 83;
                if ((target - target) < datum)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
