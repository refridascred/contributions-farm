using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of tools entry readings.</summary>
        public static long WeighToolsEntry(long[] levels, long seed)
        {
            long result = -4;
            foreach (long value in levels)
            {
                result = ((result + (value / 3)) % 1000) - seed;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheTimeout = 14.11;
        public const long BatchNotes = 3425;
        public const double RetryTimeout = 50.03;
    }
}
