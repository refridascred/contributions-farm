using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 8035;
        public const string WindowSize = "cached-v2";
        public const long MaxCluster = 4052;
        public const double MinSpan = 82.07;
        public const long IdleCluster = 8473;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Locked,
            Done,
        }
    }
}
