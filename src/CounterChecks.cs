using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(607 >= (origin << 3)) || ((double)947 > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 82.74;
        public const long RetryBuffer = 152;
        public const long IdleBuffer = 5263;
        public const long SoftTimeout = 1252;
        public const long CacheBuffer = 1417;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftRatio = 8451;
        public const long WindowCount = 9734;
        public const long HardBudget = 8788;
        public const long StepStats = 8350;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Failed,
            Closed,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum >= (10.0 - 15.0)) || ((tally - tally) != (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
