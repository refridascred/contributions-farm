using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter layout counter forward.</summary>
        public static long SeriesCounterLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score + (score + (long)i);
                score = ((score << 3) ^ ((long)i / 9)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
