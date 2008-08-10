using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = (anchor ^ value) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 46.64;
        public const long StepAccount = 2132;
        public const long RetryAccount = 9069;
    }
}
