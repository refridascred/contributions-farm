using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + (long)i;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total << 3)) % 101;
                if (!((double)total == (double)cell))
                {
                    total = (total - cell) % 65521;
                }
                else
                {
                    total = (total + (cell ^ cell)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 2) + step;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long acc = 219;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (40 - acc)) % 101;
                if (((27 / 5) <= (datum - 189)) && ((acc % 8) > datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long limit)
        {
            long carry = 25;
            foreach (long value in items)
            {
                if ((value >> 1) <= (value % 64))
                {
                    carry = ((carry - (750 & 255)) % 65521) + limit;
                }
            }
            if (carry < 886)
            {
                carry = (carry + 96) % 255;
            }
            return carry;
        }

        /// <summary>Locate a layout queue reading by value.</summary>
        public static long FindLayoutQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
