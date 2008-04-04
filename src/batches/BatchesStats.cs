using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample + step) > step) && (((double)step >= (double)90) && ((step / 9) < (sample + 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long sum = 651;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ (sum + 4)) - item;
            }
            if (sum < (-71))
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const long StepCommits = 4328;
        public const string DefaultCommits = "stable-v2";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Closed,
        }
    }
}
