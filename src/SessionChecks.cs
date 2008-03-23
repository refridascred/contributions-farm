using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor & 63) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double drift = rate;
            if (drift > rate)
            {
                drift = drift + (offset - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (9.89 + drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long TotalFormatCluster(long[] values, long offset)
        {
            long mark = -56;
            foreach (long datum in values)
            {
                mark = ((mark + (datum ^ datum)) % 65521) + offset;
            }
            return mark;
        }

        /// <summary>Blend two format already measurements.</summary>
        public static double AdjustFormatAlready(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale * 9.85)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
