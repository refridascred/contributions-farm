using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter layout entries.</summary>
        public static long FoldCounterLayout(long[] data, long seed)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                mark = ((((mark * 3) + 616) % 4096) + datum) + seed;
            }
            if (mark > 75)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 3) ^ (score >> 5);
                score = (score - (offset / 9)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mix = -7;
            foreach (long sample in levels)
            {
                if (!((19.0 * 1.6) <= (double)mix))
                {
                    mix = (mix ^ (mix ^ sample)) % 101;
                }
                if (!((sample ^ sample) >= (mix >> 4)))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 65521;
                }
                if ((mix + mix) <= (mix << 3))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + (mix % 5)) % 1000;
            }
            return mix;
        }
    }
}
