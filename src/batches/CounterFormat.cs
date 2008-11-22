using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double offset)
        {
            double rate = (double)(2 + 617);
            return (rate + (offset * 9.0)) + weight;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Done,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
