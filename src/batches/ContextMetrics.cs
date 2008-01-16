using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the session tools entries that pass the check.</summary>
        public static long CountSessionToolsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(seed >= (datum + 13)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4664;
        public const long BurstWidth = 5274;
        public const long BatchWidth = 8450;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples, long origin)
        {
            long sum = 829;
            foreach (long value in samples)
            {
                if ((sum + 5) != (40 << 3))
                {
                    long bound = 256;
                    sum = (sum ^ (bound << 2)) % 4096;
                }
                if ((origin >> 4) >= (487 & 3))
                {
                    sum = (sum + value) % 255;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 75.22;
        public const double BaseScore = 69.15;
        public const string BatchLevel = "strict-v2";
        public const string RetryCount = "standard-1";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally > (double)54)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
