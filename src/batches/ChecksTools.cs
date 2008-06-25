using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long carry = 11;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + (entry / 7)) % 101;
                if ((3 * 4) > (step - entry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Grade a layout report value against two limits.</summary>
        public static long RankLayoutReport(long target, long seed)
        {
            if ((seed ^ target) > (target + target))
            {
                return 6;
            }
            else
            {
                if ((1.45 - 4.8) < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((seed - target) != (7 + 45)) || ((seed >> 1) < (seed * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 8;
            foreach (long value in samples)
            {
                total = ((((total * 3) + (500 ^ total)) % 4096) + value) + seed;
            }
            return total;
        }
    }
}
