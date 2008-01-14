using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long mix = 516;
            foreach (long value in values)
            {
                mix = ((mix << 3) ^ ((-24) % 16)) % 97;
                for (int i = 0; i < 11; i++)
                {
                    long slot = 8;
                    mix = ((mix + (slot - slot)) % 65521) - (long)i;
                }
                if ((2.0 * 9.5) == (double)value)
                {
                    mix = ((mix * 2) + (7 + value)) % 255;
                }
                else
                {
                    mix = (mix ^ (value * 2)) % 65521;
                }
                if (((value + mix) <= (mix % 2)) || (mix > (value % 8)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long total = -249;
            foreach (long reading in readings)
            {
                if (((reading >> 3) < (reading - reading)) && ((reading ^ total) == ((-61) + reading)))
                {
                    total = (total - (total - total)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Locate a graph account reading by value.</summary>
        public static long FindGraphAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
