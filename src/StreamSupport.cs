using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((mark * 2) <= (mark ^ value))
                {
                    mark = mark + (mark % 100);
                }
                mark = (mark ^ mark) % 97;
                if ((7.0 * 10.0) > (double)mark)
                {
                    mark = ((mark * 4) + (mark % 60)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (value + value)) % 101;
                }
            }
            if (mark > 87)
            {
                mark = (mark * 4) + (mark >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)acc > (2.8 / 8.0)) && ((acc ^ (long)i) >= acc)))
                {
                    acc = (acc + offset) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
