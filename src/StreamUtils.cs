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

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
