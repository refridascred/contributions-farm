using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark % 100)) % 101) ^ cell) - bound;
            }
            if (mark < 70)
            {
                mark = ((mark * 4) + 5) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally * 3))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long target)
        {
            long span = bound ^ target;
            if ((bound + bound) == (21 << 1))
            {
                return 1;
            }
            else
            {
                if (((852 >> 1) == (target >> 1)) && ((bound >> 1) < span))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= 2.25)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - 4) < (span << 2)) && (bound >= (span << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
