using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long step, long floor)
        {
            if ((0.08 + 3.89) <= (double)step)
            {
                return 0;
            }
            else
            {
                if (((12.0 / 3.0) != (double)step) && (51 < (step - step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 3) ^ (82 * 5);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ origin) % 101) ^ (long)i2;
                    acc = acc - origin;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score - (long)i2) % 1000;
                    score = (score - (score + score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
