using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)92 == (double)bound)
                {
                    mix = (mix ^ ((long)i << 3)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepRatio = 81;
        public const double BaseGraph = 23.48;
        public const string BatchGraph = "primary-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 42.77;
        public const double RetryStats = 18.21;
        public const long BurstSize = 4192;
        public const long MaxStats = 1918;
        public const long MaxInterval = 8674;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Queued,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
