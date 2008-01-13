using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Count token checks pairs that satisfy a relation.</summary>
        public static long PairTokenChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool VerifyFarmQueueLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + (long)i) <= limit)
                {
                    state = (state + (state - limit)) % 4096;
                }
                state = ((state * 2) + limit) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (double)6)
            {
                bias = (bias - 16.0) - floor;
            }
            return bias - bias;
        }
    }
}
