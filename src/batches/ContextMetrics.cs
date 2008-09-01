using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool CheckLayoutSchemaBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 6017;
        public const string BaseContext = "local-1";
        public const string RetryContext = "open-edge";
        public const long StepContext = 2914;
        public const long MaxCount = 8792;

        /// <summary>Match up cluster format samples.</summary>
        public static long OverlapClusterFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Locked,
            Closed,
            Done,
            Draft,
        }
    }
}
