using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 6412;
        public const string StepQueue = "strict";
        public const long SoftQueue = 4413;
        public const long BurstQueue = 9794;
        public const long BaseQueue = 6642;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long acc = 588;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (acc + value)) % 4096;
            }
            if (acc < 568)
            {
                acc = (acc * 2) + (acc / 7);
            }
            return acc;
        }
    }
}
