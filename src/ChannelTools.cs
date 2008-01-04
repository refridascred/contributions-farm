using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double mean = 9.9;
            if (mean <= 11.0)
            {
                mean = (mean + mean) + rate;
            }
            return mean - (mean - floor);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long floor)
        {
            long result = 85;
            foreach (long sample in values)
            {
                if (!((result + floor) < (floor - result)))
                {
                    result = (result * 4) + (sample * 3);
                }
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
