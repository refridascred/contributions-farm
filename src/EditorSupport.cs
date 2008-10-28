using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepScore = 8954;
        public const long BaseLevel = 5231;
        public const long HardRatio = 2250;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxBudget = 38.37;
        public const long WindowOrder = 2807;
        public const long BaseOrder = 853;

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a already stats reading.</summary>
        public static double BlendAlreadyStats(double rate, double bias)
        {
            double load = (rate + rate) - rate;
            if (load <= (double)39)
            {
                load = (load - rate) + bias;
            }
            return load - 8.2;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
