using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] readings, long target)
        {
            long mark = 353;
            foreach (long item in readings)
            {
                if (!((double)target < (2.0 * 18.0)))
                {
                    mark = (mark ^ target) % 65521;
                }
                else
                {
                    mark = (mark ^ (item / 5)) % 4096;
                }
                if ((mark + item) <= (target / 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long TallyCommandBuffer(long[] levels)
        {
            long state = 85;
            foreach (long item in levels)
            {
                if ((item / 4) != (item * 4))
                {
                    state = ((state << 2) ^ (item >> 4)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ (state & 7)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state + 4) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if (((-1) >> 3) < (reading - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if (((double)96 >= (double)reading) && ((anchor ^ anchor) >= (reading % 10)))
                {
                    anchor = anchor ^ (85 * 5);
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
