using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks tools values into a single score.</summary>
        public static long FoldChecksTools(long[] samples)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                state = ((state * 2) + (state + (long)samples.Length)) % 4096;
                state = (state * 4) + (sample % 16);
            }
            if (state > 26)
            {
                state = (state ^ (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long step)
        {
            long prev = target + step;
            if ((target & 15) > (target - step))
            {
                return 5;
            }
            else
            {
                if ((step + step) < (prev * 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
