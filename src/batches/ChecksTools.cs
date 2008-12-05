using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool ValidateAccountCommandBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits session samples are out of range.</summary>
        public static long CountCommitsSessionOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((double)seed >= 2.3) || (seed < (seed & 1))))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-1";
        public const long RetryRatio = 8200;
        public const long LimitLevel = 8170;
        public const long HardLevel = 9584;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long sum = 52;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ entry) % 97) ^ (long)i;
                }
                sum = ((sum * 5) + (entry % 97)) % 101;
                sum = (sum * 5) + entry;
            }
            return sum;
        }
    }
}
