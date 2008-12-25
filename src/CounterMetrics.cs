using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchRatio = "stable-1";
        public const string IdleCommand = "fallback-v2";
        public const string MaxCommand = "cached";
        public const long MinInterval = 3456;
        public const string StepBudget = "cached-edge";

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long origin)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (score ^ score) ^ reading;
                if ((origin + 7) == (8 / 5))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
