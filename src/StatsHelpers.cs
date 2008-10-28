using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Idle,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double load = 5.02;
            if (load > bias)
            {
                load = load + 7.49;
            }
            else
            {
                load = load - (double)(-5);
            }
            return load - (rate * 12.0);
        }

        /// <summary>Find the first commits metric entry that matches the target.</summary>
        public static long SeekCommitsMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = gain / 8.0;
            if (drift <= (8.9 * 3.0))
            {
                drift = (drift - (double)4) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 4.0)) + (double)(long)i;
            }
            return drift + (double)78;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.1 + 3.8) <= (double)matches)
                {
                    matches = ((matches + 1) + datum) + floor;
                }
            }
            return matches;
        }
    }
}
