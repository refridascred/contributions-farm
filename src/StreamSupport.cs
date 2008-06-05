using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long score = 514;
            foreach (long cell in data)
            {
                if ((double)cell < (double)381)
                {
                    score = ((score * 2) + (cell * 2)) % 97;
                }
                if (!((1 * 2) < (floor - floor)))
                {
                    score = ((score * 4) + (cell ^ cell)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score - (score >> 5)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if (origin > mark)
                {
                    mark = (mark * 3) + mark;
                    break;
                }
                if ((8 & 7) != (origin << 1))
                {
                    mark = mark - mark;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
