using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long score = 75;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((double)cell > (1.0 - 2.4))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of tools filter entries.</summary>
        public static long FoldToolsFilter(long[] samples)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                mix = (mix + (mix - cell)) % 255;
                if (!((mix & 3) <= (cell / 9)))
                {
                    mix = mix ^ (cell >> 4);
                }
                mix = (mix + (cell + mix)) % 1000;
            }
            if (mix < 691)
            {
                mix = (mix * 4) + (mix % 2);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long TallyQueueOrder(long[] readings)
        {
            long acc = 828;
            foreach (long datum in readings)
            {
                if ((datum + 787) < acc)
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < 6)
            {
                acc = acc + (3 % 24);
            }
            return acc % 97;
        }
    }
}
