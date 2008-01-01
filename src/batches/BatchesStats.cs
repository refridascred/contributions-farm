using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 9473;
        public const long BaseProfile = 7919;
        public const long SoftTimeout = 6200;

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long AuditPayloadRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry & 3) >= (71 / 7)) && ((double)matches <= 3.65))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 6000;
        public const long StepRatio = 9482;
        public const long SoftBudget = 6170;
        public const string CacheTimeout = "latest-edge";
    }
}
