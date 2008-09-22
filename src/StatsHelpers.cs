using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 5990;
        public const long DefaultBudget = 6865;
        public const string MinMetrics = "open";
        public const long BatchFactor = 2430;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 346;
            foreach (long value in data)
            {
                mix = (mix ^ value) % 65521;
                if (((-6) ^ 715) < (value * 2))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Retry,
            Active,
            Locked,
            Done,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}
