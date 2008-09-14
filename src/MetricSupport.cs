using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (5.6 / 6.0))
            {
                drift = drift - (rate / 8.0);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (drift / 3.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long state = 392;
            foreach (long sample in values)
            {
                if (state <= (sample & 127))
                {
                    state = (state - state) % 255;
                    continue;
                }
                state = (state << 2) ^ sample;
                if ((sample + sample) == (11 >> 3))
                {
                    state = state - (sample & 1);
                }
            }
            return state % 4096;
        }
    }
}
