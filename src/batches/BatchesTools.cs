using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if ((1.07 * 17.0) <= (double)step)
                {
                    acc = ((acc << 2) ^ (long)i) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 3) + 326) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)bound <= 1.2) || ((hits ^ bound) <= (sample - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
