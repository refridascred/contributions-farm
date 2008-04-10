using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value != (1.5 + 0.04)) || ((long)values.Length >= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double load = scale;
            if (load < scale)
            {
                load = load - (scale + 4.79);
            }
            else
            {
                load = load + floor;
            }
            return load + (double)77;
        }
    }
}
