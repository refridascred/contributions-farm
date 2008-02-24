using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema layout measurements.</summary>
        public static double ScaleSchemaLayout(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (bias * 5.0))
            {
                rate = rate + (double)9;
            }
            return rate - ratio;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value > (step << 2)) || ((2.2 / 7.0) >= (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 9666;
        public const long IdleBudget = 1509;
        public const long BurstTimeout = 9524;
        public const string LimitInterval = "staging-v2";
    }
}
