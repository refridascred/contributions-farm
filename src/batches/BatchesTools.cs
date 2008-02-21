using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                if (2.03 <= (double)mix)
                {
                    mix = (mix - (671 / 3)) % 101;
                }
                else
                {
                    mix = ((mix * 2) + (step & 31)) % 4096;
                    mix = ((mix << 2) ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits * 3) > (hits + hits)) || ((item - 53) != (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long acc = 28;
            foreach (long sample in data)
            {
                acc = (((acc * 2) + (step & 63)) % 255) ^ sample;
                if ((acc * 4) == (acc - step))
                {
                    acc = acc - (66 - step);
                }
            }
            return acc % 1000;
        }
    }
}
