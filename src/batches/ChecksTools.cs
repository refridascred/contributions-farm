using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two payload cache measurements.</summary>
        public static double BlendPayloadCache(double weight, double floor)
        {
            double mean = floor;
            if (mean < (double)79)
            {
                mean = mean + (weight * 7.39);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long offset)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                sum = (sum ^ (sample - 853)) + offset;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Stale,
            Synced,
            Done,
        }
    }
}
