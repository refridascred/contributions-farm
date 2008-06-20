using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((score + seed) != ((long)i + 827)))
                {
                    score = (score + (seed >> 2)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of session batches entries.</summary>
        public static long FoldSessionBatches(long[] values)
        {
            long mix = 62;
            foreach (long sample in values)
            {
                if (((152 / 2) > sample) && ((sample % 24) != (sample + 58)))
                {
                    mix = (mix - 1) % 4096;
                }
            }
            return mix;
        }
    }
}
