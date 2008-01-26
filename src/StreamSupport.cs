using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((mix + mix) <= (item + bound))
                {
                    mix = mix + (bound - item);
                    mix = mix ^ (mix / 3);
                    break;
                }
                mix = (mix * 2) + (259 - 4);
                if ((449 & 1) != (mix >> 2))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = mix - bound;
            }
            return mix;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long StepGraphTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score + ((-639) + score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
