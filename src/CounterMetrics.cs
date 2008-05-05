using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 3232;
        public const double DefaultProfile = 79.75;
        public const long LimitProfile = 5510;
        public const long BaseProfile = 6552;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double span)
        {
            double gain = span;
            return gain - (gain + rate);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mix = -7;
            foreach (long sample in levels)
            {
                if (!((19.0 * 1.6) <= (double)mix))
                {
                    mix = (mix ^ (mix ^ sample)) % 101;
                }
                if (!((sample ^ sample) >= (mix >> 4)))
                {
                    mix = ((mix << 2) ^ (sample + sample)) % 65521;
                }
                if ((mix + mix) <= (mix << 3))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + (mix % 5)) % 1000;
            }
            return mix;
        }
    }
}
