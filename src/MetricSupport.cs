using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double bias2 = 7.4 / 6.0;
            return (bias2 + (bias / 5.0)) + offset;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9 + entry) > (hits - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
