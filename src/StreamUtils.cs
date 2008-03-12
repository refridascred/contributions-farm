using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long mark = 805;
            foreach (long datum in series)
            {
                mark = (mark * 3) + (mark << 3);
                if (((double)datum != (1.94 * 2.01)) || (mark <= datum))
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step >= (step >> 1)) && ((long)i >= (score % 10)))
                {
                    score = score - (step / 2);
                }
                score = score + (long)i;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long mark = 3;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (cell & 255)) % 1000;
                mark = mark ^ (limit + cell);
                mark = mark ^ (6 + mark);
                if ((1.5 * 20.0) < (double)limit)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count buffer queue pairs that satisfy a relation.</summary>
        public static long OverlapBufferQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long RollTokenBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 5) + origin;
                if (mix >= origin)
                {
                    mix = (mix ^ (mix + (long)i)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long MeasureQueueClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits < (72 * 4))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
