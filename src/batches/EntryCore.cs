using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4105;
        public const string DefaultWidth = "alpha-v2";
        public const long HardBudget = 9245;
        public const double LimitFactor = 7.57;
        public const long LimitBatch = 9779;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long offset)
        {
            long state = 88;
            foreach (long datum in readings)
            {
                if ((state << 3) > (datum << 3))
                {
                    state = ((state * 3) + 67) - offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double mean = ratio / 2.0;
            if (mean >= (double)422)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)2) - (double)(long)i;
            }
            return mean + (offset - ratio);
        }
    }
}
