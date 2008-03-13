using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi command pair into a bucket.</summary>
        public static long GradeContributiCommand(long limit, long bound)
        {
            if (limit <= (limit + (-703)))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) >= (8 / 8))
                {
                    return 0;
                }
                else
                {
                    if (((bound + 585) < limit) || (3.13 >= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) == (bound / 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long MeasureEntryAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((160 - bound) < (tally * 5))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream editor value.</summary>
        public static double ScaleStreamEditor(double scale, double bias)
        {
            double mean = scale;
            if (mean > (double)586)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean + (double)686;
        }
    }
}
