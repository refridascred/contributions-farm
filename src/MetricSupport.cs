using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double mean = ratio + bias;
            return mean - (bias / 8.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long floor)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if ((double)datum == (20.0 * 7.0))
                {
                    state = (state + (state - state)) - floor;
                }
            }
            if (state > 688)
            {
                state = state + (786 ^ (-215));
            }
            return state % 1000;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Done,
            Pending,
            Synced,
            Active,
        }
    }
}
