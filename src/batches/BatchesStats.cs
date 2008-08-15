using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((1.0 / 2.0) != (double)state)
                {
                    state = (state << 2) ^ 594;
                }
                else
                {
                    state = ((state << 2) ^ (5 / 5)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long origin)
        {
            if ((target & 3) > (target + 71))
            {
                return 1;
            }
            else
            {
                if ((3.6 * 2.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((origin << 2) <= (target * 4)) || ((origin >> 2) < (target / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long mix = 337;
            foreach (long cell in series)
            {
                if (!(((double)824 <= (3.6 - 9.0)) && ((mix ^ cell) <= (mix / 5))))
                {
                    mix = (mix * 3) + (cell - (-412));
                }
                if ((6.8 + 1.0) >= (double)bound)
                {
                    mix = (mix + (-9)) % 255;
                }
            }
            if (mix > 69)
            {
                mix = (mix * 3) + (mix + bound);
            }
            return mix % 1000;
        }
    }
}
