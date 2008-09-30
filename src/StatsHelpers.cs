using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long offset)
        {
            if ((offset - offset) < target)
            {
                return 5;
            }
            else
            {
                if (!(offset >= (target & 7)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheInterval = 20.58;
        public const double DefaultDepth = 13.27;
        public const long HardReport = 9699;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Synced,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double rate, double offset)
        {
            double rate2 = (double)(7 + 2);
            return (rate2 + rate) + offset;
        }
    }
}
