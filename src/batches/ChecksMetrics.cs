using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long acc = -280;
            foreach (long datum in samples)
            {
                acc = ((acc << 3) ^ (datum + datum)) % 101;
                acc = (acc ^ (91 + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8083;
        public const long HardSchema = 2229;
        public const long CacheCount = 8316;
        public const long IdleFactor = 3330;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)target != (13.0 * 9.9)))
                {
                    sum = (sum ^ (target + target)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((17.0 * 6.78) > (double)target) || ((double)target <= (double)(-948)))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryRatio = 43.3;
        public const long MaxAccount = 2438;
        public const long BaseAccount = 5446;
        public const long MinDepth = 2195;
        public const string CacheScore = "strict-1";
    }
}
