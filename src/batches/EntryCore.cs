using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Done,
            Active,
            Closed,
            New,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double rate, double offset)
        {
            double load = 1.95 * 7.0;
            return ((load + 4.0) + rate) + offset;
        }

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool GuardStatsCacheLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 8129;
        public const string DefaultRatio = "primary-edge";
        public const long CacheGraph = 961;
    }
}
