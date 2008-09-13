using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long carry = 276;
            foreach (long item in levels)
            {
                carry = carry - (item + 79);
            }
            return carry % 1000;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long state = -23;
            foreach (long item in series)
            {
                state = (state * 2) + state;
                state = state + (item + state);
                if ((state - state) > 873)
                {
                    state = (state + (16 ^ 3)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long step)
        {
            if ((step - 53) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if (step >= 382)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 31) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metrics farm series from a seed.</summary>
        public static long StepMetricsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (mix >> 5)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long gap = seed - offset;
            if (9.33 < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((double)gap >= 5.15) && ((double)seed <= (0.9 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
