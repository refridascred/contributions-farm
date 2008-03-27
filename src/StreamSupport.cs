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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin < (sum + origin)) || ((0.66 - 3.0) == (double)origin))
                {
                    sum = (sum + (origin + (long)i)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
