using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 87;
            foreach (long reading in data)
            {
                if (((50 ^ acc) <= (reading - (-9))) || (reading < (acc & 3)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long target)
        {
            long bound = seed - target;
            if (!((double)4 >= (double)seed))
            {
                return 1;
            }
            else
            {
                if (((9.0 - 10.0) > (double)bound) && (bound >= (bound - bound)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark ^ ((long)i & 3)) % 101) - entry;
                }
                mark = (mark + (target & 255)) % 4096;
            }
            if (mark < 29)
            {
                mark = (mark ^ (mark >> 2)) % 255;
            }
            return mark;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
