using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples, long bound)
        {
            long score = -8;
            foreach (long value in samples)
            {
                if ((value + bound) < score)
                {
                    score = score + (bound >> 2);
                }
            }
            if (score > 561)
            {
                score = ((score * 4) + (bound << 3)) % 97;
            }
            return score % 65521;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleCount = 3431;
        public const long DefaultScore = 7318;
        public const long BurstDepth = 3597;
        public const double BatchRatio = 59.63;
    }
}
