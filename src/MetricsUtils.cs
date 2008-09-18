using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a checks report reading.</summary>
        public static double AdjustChecksReport(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - scale) - (double)(long)i;
            }
            return drift - (double)(-54);
        }

        /// <summary>Measure how many support already samples are out of range.</summary>
        public static long MeasureSupportAlreadyMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((double)tally <= (19.0 + 3.0)))
                {
                    tally = ((tally + 3) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long mix = 28;
            foreach (long cell in readings)
            {
                mix = ((mix + origin) % 65521) + cell;
            }
            if (mix < 3)
            {
                mix = (mix << 2) ^ 542;
            }
            return mix;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long state = 42;
            foreach (long reading in series)
            {
                if ((reading / 3) >= (400 ^ state))
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 37)
            {
                state = ((state * 4) + ((long)series.Length * 2)) % 101;
            }
            return state % 1000;
        }
    }
}
