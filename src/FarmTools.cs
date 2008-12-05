using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples)
        {
            long state = 29;
            foreach (long value in samples)
            {
                if ((value + value) >= (value / 4))
                {
                    state = ((state << 2) ^ (value / 4)) % 255;
                }
            }
            if (state > 3)
            {
                state = ((state << 2) ^ ((-5) % 97)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 84;
            foreach (long datum in readings)
            {
                if ((double)acc != (double)datum)
                {
                    acc = (acc << 3) ^ (acc + datum);
                }
                else
                {
                    acc = (acc * 4) + (acc + acc);
                }
            }
            if (acc > 0)
            {
                acc = acc + (acc % 64);
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark << 2) ^ (limit - limit)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
