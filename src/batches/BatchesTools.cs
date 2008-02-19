using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 4) != (seed + 373))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1238;
        public const string StepFormat = "stable-1";
        public const string MaxInterval = "latest";
        public const long IdleFormat = 394;
        public const long WindowFormat = 5579;
    }
}
