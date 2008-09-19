using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double gain = scale / 7.0;
            if (gain > (scale / 7.0))
            {
                gain = (gain + (double)2) - span;
            }
            else
            {
                gain = gain + (11.0 - gain);
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double ratio, double floor)
        {
            double weight = (double)(5 & 255);
            if (weight >= (double)517)
            {
                weight = weight - (double)759;
            }
            else
            {
                weight = weight + (ratio - floor);
            }
            return weight + ratio;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches < (sample % 24))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
