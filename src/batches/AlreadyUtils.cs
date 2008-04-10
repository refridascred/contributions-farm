using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long state = -87;
            foreach (long item in data)
            {
                state = ((state + (target % 3)) % 1000) ^ item;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardBudget = 82.09;
        public const double MinDepth = 31.37;
        public const string RetryCommand = "open-edge";
        public const long MinCommand = 2450;
        public const double SoftCount = 8.48;

        /// <summary>Check that every cluster layout entry stays within the limit.</summary>
        public static bool ValidateClusterLayoutRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
