using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long AuditFarmEditorGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7 + target) <= (target + 706))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 1371;
        public const long BaseFormat = 5246;
        public const long MinFormat = 9759;
        public const string StepBudget = "stable-1";
        public const long MinInterval = 189;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 1295;
        public const long BatchLevel = 2280;
        public const long CacheInterval = 5393;
        public const double BatchNotes = 43.4;
        public const string RetryScore = "local";

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
