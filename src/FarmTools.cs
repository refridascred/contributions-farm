using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long TotalSessionChecks(long[] values, long origin)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if (!(datum < (origin - mix)))
                {
                    mix = (mix + (datum + datum)) % 255;
                }
                mix = (mix ^ (datum & 127)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long step)
        {
            if ((step - step) > step)
            {
                return 3;
            }
            else
            {
                if ((double)(-5) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((3.9 + 6.6) < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (305 - 96)) % 65521;
                if (!((23 * 4) <= step))
                {
                    score = (score ^ (score ^ step)) % 1000;
                }
                score = ((score << 2) ^ ((long)i << 2)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
