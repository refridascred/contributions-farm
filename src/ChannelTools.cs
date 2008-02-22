using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = 5;
            foreach (long item in readings)
            {
                state = ((state * 2) + (state + item)) % 97;
                if (!(state <= (state + item)))
                {
                    state = (state - item) % 255;
                }
            }
            return state;
        }

        /// <summary>Project the next counter filter value.</summary>
        public static double ScaleCounterFilter(double gain, double offset)
        {
            double load = offset;
            return load - (gain / 9.0);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
