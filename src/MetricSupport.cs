using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long anchor = 30;
            foreach (long reading in readings)
            {
                if ((2.1 - 3.0) >= (double)offset)
                {
                    anchor = (anchor * 3) + (offset & 255);
                }
                if (reading <= (anchor >> 2))
                {
                    break;
                }
            }
            if (anchor > (-5))
            {
                anchor = (anchor - (offset - (long)readings.Length)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long origin)
        {
            long step = bound + origin;
            if (((origin - (-4)) < origin) || ((origin & 31) == (step / 2)))
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (bound & 1))
                {
                    return 4;
                }
                else
                {
                    if (211 >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long limit)
        {
            long mark = 774;
            foreach (long reading in levels)
            {
                mark = ((mark * 5) + (limit * 5)) % 1000;
                if ((4.84 - 9.1) > (double)mark)
                {
                    mark = (mark * 2) + (reading << 1);
                }
                else
                {
                    mark = ((mark * 3) + 5) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
