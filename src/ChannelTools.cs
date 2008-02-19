using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (floor + floor)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long limit)
        {
            long total = 331;
            foreach (long sample in readings)
            {
                if (15.0 < (double)total)
                {
                    total = (total + (sample + limit)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of already token entries.</summary>
        public static long FoldAlreadyToken(long[] items, long limit)
        {
            long score = 64;
            foreach (long datum in items)
            {
                score = (score - (limit + score)) - datum;
            }
            return score % 4096;
        }
    }
}
