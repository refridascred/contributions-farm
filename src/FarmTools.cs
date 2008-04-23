using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long ScoreCounterContext(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                if (((69 << 3) == (item * 2)) && ((double)item >= 6.0))
                {
                    break;
                }
                if (8 >= (item + mix))
                {
                    mix = mix ^ (item - item);
                }
            }
            if (mix > 377)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a context layout counter forward.</summary>
        public static long DeriveContextLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((13.0 <= (double)(long)i) || ((4 + mix) == (target + target)))
                {
                    mix = mix - (target * 4);
                }
                if (!((1.7 * 3.9) == (double)target))
                {
                    mix = (mix ^ ((long)i + target)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
