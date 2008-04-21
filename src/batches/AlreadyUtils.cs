using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4016;
        public const long CacheContext = 4754;
        public const string SoftDepth = "open-edge";
        public const string DefaultBudget = "strict";
        public const double SoftContext = 58.32;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (bias + bias))
            {
                rate = (rate + 13.0) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 6.8) + (double)(long)i;
            }
            return rate + (5.1 - bias);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitDepth = 19.77;
        public const long MaxCount = 2212;
        public const long BaseScore = 3474;
        public const long RetryBudget = 1328;
        public const string MaxCounter = "cached-edge";
    }
}
