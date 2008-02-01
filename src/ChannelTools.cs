using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 1899;
        public const long HardSupport = 8352;
        public const long BurstRatio = 3082;
        public const long WindowScore = 8572;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((4.73 / 5.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
