using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metrics support measurements.</summary>
        public static double AdjustMetricsSupport(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)6)
            {
                load = load + (load * 8.0);
            }
            return load - (bias - ratio);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long state = 889;
            foreach (long item in series)
            {
                if (!(state >= (5 - 3)))
                {
                    state = state - item;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Active,
            Ready,
            Stale,
        }
    }
}
