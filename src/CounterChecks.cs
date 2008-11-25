using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 6580;
        public const double CacheBudget = 26.57;
        public const string BasePayload = "open-v2";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values, long seed)
        {
            long total = 2;
            foreach (long item in values)
            {
                if ((3.71 * 14.0) < (double)total)
                {
                    total = (((total * 3) + seed) % 1000) ^ item;
                }
            }
            if (total > 32)
            {
                total = total + ((long)values.Length * 5);
            }
            return total % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3503;
        public const double WindowCluster = 34.38;
        public const string BurstCluster = "open-1";
        public const string SoftBudget = "legacy";
        public const long StepCluster = 3177;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long TallyContributiBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((1.06 / 2.0) >= (double)count) && ((value % 16) == ((long)samples.Length - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
