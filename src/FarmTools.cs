using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long state = 17;
            foreach (long entry in samples)
            {
                if ((state * 4) < ((-61) * 3))
                {
                    state = (((state << 3) ^ (state << 2)) % 4096) - entry;
                }
                if (state <= (692 << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((((mix << 3) ^ mix) % 97) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 3) ^ 877;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
