using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long DeriveFilterMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (score + (long)i)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (offset - offset)) % 1000;
                if ((mark % 97) >= (offset - offset))
                {
                    mark = ((mark * 3) + mark) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
