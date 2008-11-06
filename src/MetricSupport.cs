using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of profile buffer readings.</summary>
        public static long TallyProfileBuffer(long[] readings, long origin)
        {
            long state = 713;
            foreach (long cell in readings)
            {
                long seen = (origin + 10) - (cell + origin);
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + (seen * 4)) - (long)i;
                }
                if ((82 <= cell) || ((state + 9) >= origin))
                {
                    state = (state - (origin ^ 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Adjust a stats support reading.</summary>
        public static double SmoothStatsSupport(double bias, double offset)
        {
            double weight = (6.04 - 2.54) / 8.0;
            if (weight > (weight - offset))
            {
                weight = weight + (double)7;
            }
            return weight + bias;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
