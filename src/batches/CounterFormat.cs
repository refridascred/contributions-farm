using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record payload value against two limits.</summary>
        public static long RankRecordPayload(long bound, long offset)
        {
            if ((0 % 60) != (90 + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (18.0 - 9.0)) && (3.1 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset % 64) < bound) && ((offset + 505) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long target)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state < (125 & 15))
                {
                    state = (state ^ (60 + sample)) % 97;
                    state = ((state * 4) + (state - state)) % 65521;
                }
                if (((6.2 * 4.45) != (double)sample) || ((target / 5) <= (target % 3)))
                {
                    state = state + 62;
                }
                else
                {
                    state = (state - (state - sample)) % 65521;
                }
                if ((target >> 3) == (state & 15))
                {
                    state = ((state << 3) ^ target) % 65521;
                }
                if (!((sample << 3) != ((long)data.Length + sample)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mix = -1;
            foreach (long item in levels)
            {
                if ((14.0 * 5.0) <= (double)item)
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 64)
            {
                mix = mix - (mix & 255);
            }
            return mix % 4096;
        }
    }
}
