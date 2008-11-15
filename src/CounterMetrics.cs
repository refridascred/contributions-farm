using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 8115;
        public const string BaseCluster = "fallback-edge";
        public const long StepSize = 5319;

        /// <summary>Iterate the checks batches series from a seed.</summary>
        public static long RollChecksBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result + (result + target)) % 65521;
                result = result - (result - result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
