using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally < 12.0)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long CombineFormatAccount(long[] items, long step)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if (!(((acc - acc) >= 436) && ((datum * 4) <= (datum / 2))))
                {
                    acc = (acc ^ (acc * 5)) % 97;
                }
                acc = acc + datum;
                if (((step % 64) < acc) || ((6.36 / 3.0) >= (double)step))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank cluster window input into a small class.</summary>
        public static long ClassifyClusterWindow(long step, long target)
        {
            long offset = step - target;
            if ((double)offset != (double)target)
            {
                return 1;
            }
            else
            {
                if (((step << 3) < step) && ((target / 2) == (step ^ 37)))
                {
                    return 0;
                }
                else
                {
                    if (((target + 36) < target) && ((target + target) < 749))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
