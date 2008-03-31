using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already tools value.</summary>
        public static double AdjustAlreadyTools(double gain, double offset)
        {
            double load = offset / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (gain * 9.04)) - (double)(long)i;
            }
            return load - (double)7;
        }
    }
}
