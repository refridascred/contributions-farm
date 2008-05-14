using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Ready,
            Done,
            New,
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long MeasureNotesFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 5) <= 822)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double load = (double)(286 & 7);
            if (load >= (ratio - ratio))
            {
                load = (load - ratio) - span;
            }
            return load + ratio;
        }
    }
}
