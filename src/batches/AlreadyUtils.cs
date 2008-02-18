using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleFactor = 1532;
        public const string RetryRecord = "latest-edge";
        public const long StepRatio = 3007;
        public const string MaxTimeout = "alpha-edge";

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (mix + (value * 5)) % 101;
            }
            if (mix < 760)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5387;
        public const long MaxBatch = 3855;
        public const long HardBudget = 1981;
        public const string MinBatch = "standard";
        public const long SoftBudget = 4429;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell >= (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
