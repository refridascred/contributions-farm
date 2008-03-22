using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long limit)
        {
            long mix = 35;
            foreach (long cell in values)
            {
                if (cell < 795)
                {
                    mix = ((mix ^ (-807)) % 4096) - limit;
                }
                if (!((double)cell > (0.19 * 9.2)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mix = 943;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ reading) - (long)i;
                }
                if ((1.0 * 9.57) >= (double)reading)
                {
                    mix = mix + (mix ^ mix);
                }
                if ((double)reading != (1.0 / 9.0))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next token queue value from a seed.</summary>
        public static long SeriesTokenQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((double)score < 2.9) && ((double)score == (7.7 * 1.08)))
                {
                    score = (score - score) % 255;
                }
                if (((origin >> 4) != (origin >> 3)) || ((score / 7) <= score))
                {
                    score = (score ^ (score >> 5)) % 101;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
