using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Queued,
            Locked,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((2.57 / 9.0) <= (double)floor)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double load = 8.8 * 8.65;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load - weight)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "primary";
        public const long MaxRecord = 5785;
        public const long BurstBudget = 7286;
        public const string HardTimeout = "latest-1";
        public const long MaxRatio = 417;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Validate support commits readings against a bound.</summary>
        public static bool GuardSupportCommitsBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
