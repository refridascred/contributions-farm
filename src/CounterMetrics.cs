using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                mix = (mix - mix) % 1000;
                mix = (mix - cell) % 101;
                if (cell > (57 - mix))
                {
                    mix = (mix << 2) ^ cell;
                }
            }
            if (mix > 16)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 255;
            }
            return mix;
        }

        /// <summary>Combine format token values into a single score.</summary>
        public static long CombineFormatToken(long[] items)
        {
            long score = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (5.0 / 5.0))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (7 & 127);
                }
            }
            return score;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long bound)
        {
            if ((double)target != (5.77 - 8.0))
            {
                return 4;
            }
            else
            {
                if (!((4 + bound) <= (target % 97)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
