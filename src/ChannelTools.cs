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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Closed,
            Retry,
        }
    }
}
