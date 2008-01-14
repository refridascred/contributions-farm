using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (9.9 < (double)result)
                {
                    result = (result * 3) + (result / 3);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result + (target - result)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix != (20.0 * 8.0))
                {
                    mix = (mix + limit) % 4096;
                }
                mix = ((mix << 3) ^ (2 / 4)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] data, long step)
        {
            long state = -12;
            foreach (long cell in data)
            {
                state = (state + (step - state)) - cell;
                state = ((state << 2) ^ ((-3) >> 4)) % 97;
            }
            return state % 1000;
        }
    }
}
