using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metrics payload value against two limits.</summary>
        public static long GradeMetricsPayload(long seed, long step)
        {
            if ((seed > (step + step)) || (((-94) % 8) > step))
            {
                return 1;
            }
            else
            {
                if ((seed - step) <= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (step > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step - step) < (190 & 1)) && ((double)seed != (3.0 - 12.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((6.0 * 13.0) >= (double)target)
                {
                    state = state ^ (target % 10);
                    state = (state ^ (-814)) % 97;
                }
                else
                {
                    state = (state - state) % 97;
                }
                state = (state - (state >> 1)) % 4096;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long carry = 91;
            foreach (long value in series)
            {
                carry = (carry ^ (value % 12)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of report counter entries.</summary>
        public static long WeighReportCounter(long[] values)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                if ((2.74 / 5.0) == (double)entry)
                {
                    acc = ((acc * 2) + (acc - acc)) % 1000;
                }
            }
            if (acc > 488)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}
