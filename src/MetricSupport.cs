using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)355 == (double)tally)
                {
                    tally = ((tally + 3) + reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift <= 7.32)
            {
                drift = drift - (0.83 / 7.0);
            }
            return drift + (weight * 4.52);
        }
    }
}
