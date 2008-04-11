using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the contributi stream series from a seed.</summary>
        public static long RollContributiStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (result - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double rate = (bias2 - bias2) * 4.91;
            if (rate <= rate)
            {
                rate = rate + (double)543;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4463;
        public const long CacheBatches = 9287;
        public const long IdleBatches = 7788;
        public const long HardSpan = 4262;
        public const long CacheScore = 5174;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Synced,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Locked,
            Retry,
            Paused,
        }
    }
}
