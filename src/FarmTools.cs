using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate entry stream samples.</summary>
        public static long FoldEntryStream(long[] samples)
        {
            long mix = 436;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (mix / 2)) % 65521) ^ sample;
            }
            if (mix > 2)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(((seed + 53) <= (84 % 10)) || ((seed + score) >= (score << 3))))
                {
                    score = (score - (seed - seed)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 7810;
        public const long IdleBudget = 7076;
        public const long LimitSpan = 174;
    }
}
