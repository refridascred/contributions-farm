using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stats route entries.</summary>
        public static long ScoreStatsRoute(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                if (!((anchor >> 4) < (anchor ^ step)))
                {
                    anchor = ((anchor ^ anchor) % 65521) - value;
                }
            }
            return anchor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long step, long step2)
        {
            long lane = step ^ step2;
            if ((step + lane) > (lane ^ step))
            {
                return 8;
            }
            else
            {
                if (!(step2 > (step2 ^ lane)))
                {
                    return 4;
                }
                else
                {
                    if (step <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 3) == (item - hits)) || ((item + hits) != (item - 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
