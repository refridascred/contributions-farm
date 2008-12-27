using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long result = 621;
            foreach (long value in samples)
            {
                if ((20.0 > (double)value) && ((double)floor > (double)value))
                {
                    result = (result + (3 * 5)) % 97;
                }
            }
            return result;
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
