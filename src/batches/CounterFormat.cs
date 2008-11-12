using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long TallyStreamEntryMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading ^ reading) != ((long)levels.Length + reading)) && ((double)(long)levels.Length <= (9.99 * 9.2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double mean = floor;
            if (mean > (double)27)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + floor;
            }
            return mean - (double)43;
        }

        /// <summary>Classify a metrics stream pair into a bucket.</summary>
        public static long GradeMetricsStream(long offset, long floor)
        {
            if (((0.2 / 3.0) <= (double)offset) || (offset <= floor))
            {
                return 4;
            }
            else
            {
                if ((4.4 / 3.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset / 8) <= (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + floor) <= (offset ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
