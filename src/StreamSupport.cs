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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long seed)
        {
            if ((20.0 + 4.7) < (double)step)
            {
                return 3;
            }
            else
            {
                if (step <= (44 - seed))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
