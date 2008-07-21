using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long state = -8;
            foreach (long datum in items)
            {
                if ((double)7 != (double)datum)
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 64)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)hits >= (5.51 - 18.0)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long target)
        {
            if (step > (step + step))
            {
                return 0;
            }
            else
            {
                if (((target - target) != (3 - target)) || ((double)step == (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((target * 3) <= (-82))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step >= 3.8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
