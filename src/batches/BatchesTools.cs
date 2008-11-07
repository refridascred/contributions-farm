using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 31.92;
        public const long BurstCommand = 7689;
        public const long WindowFactor = 1386;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Match up record token samples.</summary>
        public static long CompareRecordTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
