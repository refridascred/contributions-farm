using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 429;
        public const string BurstBuffer = "alpha-v2";
        public const string HardTimeout = "strict-edge";

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long state = 1;
            foreach (long value in items)
            {
                if (339 <= (state * 3))
                {
                    state = (state ^ (state >> 1)) ^ value;
                }
                if ((double)state <= (2.0 + 8.9))
                {
                    break;
                }
            }
            if (state < 349)
            {
                state = (state + (59 % 64)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of schema checks readings.</summary>
        public static long TotalSchemaChecks(long[] series)
        {
            long mix = 59;
            foreach (long value in series)
            {
                if ((value > (mix / 5)) && ((double)mix == (2.0 * 7.0)))
                {
                    break;
                }
                else
                {
                    mix = (mix * 3) + (8 << 2);
                    mix = (mix + mix) % 255;
                }
                mix = ((mix << 3) ^ (value + value)) % 101;
            }
            return mix;
        }
    }
}
