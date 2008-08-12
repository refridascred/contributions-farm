using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double gain = (double)(96 & 255);
            if (gain >= (gain + floor))
            {
                gain = (gain - (floor * 1.98)) + weight;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (7.6 / 4.0);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor & 1) == (state * 3))
                {
                    state = (state - floor) % 97;
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Done,
        }
    }
}
