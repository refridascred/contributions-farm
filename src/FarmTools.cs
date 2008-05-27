using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double load = 3.2 + (span / 9.0);
            if (load >= (load * 1.54))
            {
                load = (load - (double)79) - scale;
            }
            else
            {
                load = load + (double)(-995);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (8.1 / 4.0)) + (double)(long)i;
            }
            return load + (2.7 / 3.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (857 <= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
