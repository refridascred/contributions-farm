using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > (sample & 63))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias + 7.81))
            {
                drift = drift + 1.2;
            }
            return drift + floor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two stream tools measurements.</summary>
        public static double AdjustStreamTools(double ratio, double offset)
        {
            double scale = (double)69;
            if (scale >= (offset - ratio))
            {
                scale = scale - (ratio + ratio);
            }
            else
            {
                scale = scale - 0.61;
            }
            return scale + scale;
        }
    }
}
