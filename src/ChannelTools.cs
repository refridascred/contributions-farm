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

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowDepth = 51.02;
        public const long SoftRatio = 6889;
        public const long StepOrder = 2716;
        public const long LimitLevel = 4267;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
