using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally + reading) <= (reading + tally)) || ((tally + reading) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ (866 - state)) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long DigestBufferSession(long[] data)
        {
            long mix = 76;
            foreach (long item in data)
            {
                if (((mix >> 2) > (48 - item)) && (91 <= mix))
                {
                    mix = mix ^ (16 & 31);
                }
                if ((double)mix > (7.0 + 7.2))
                {
                    break;
                }
            }
            if (mix > 66)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mark = 497;
            foreach (long reading in values)
            {
                if (!(mark > (reading - mark)))
                {
                    mark = (mark * 4) + (mark + reading);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }
    }
}
