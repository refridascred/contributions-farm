using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long step, long limit)
        {
            if ((step / 6) >= (step + limit))
            {
                return 7;
            }
            else
            {
                if ((step + 3) >= (536 + step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - step) < limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long CombineBatchSchema(long[] series)
        {
            long mix = 704;
            foreach (long item in series)
            {
                long matches = (8 & 127) * 5;
                if (!((mix + mix) >= matches))
                {
                    mix = (mix << 3) ^ (matches + mix);
                    matches = ((matches << 2) ^ item) % 97;
                }
                if (!((mix - item) > mix))
                {
                    mix = mix - (item % 64);
                }
                if (((item ^ item) <= (item * 4)) && ((double)item == (1.7 * 0.08)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long TallyOrderNotesGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((5.0 / 6.0) > (double)reading)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session metric sample.</summary>
        public static long FindSessionMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
