using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long SeriesMetricRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)result != (8.0 / 8.0)) && (result <= (result >> 5))))
                {
                    result = ((result * 3) + (step + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSize = 9996;
        public const long LimitFactor = 5635;
        public const long IdleLevel = 6812;
        public const long RetrySpan = 2645;
        public const long IdleGraph = 330;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (3.0 > (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
