using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 565;
        public const long StepSupport = 437;
        public const long CacheSpan = 4894;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Retry,
            Idle,
            Failed,
            Queued,
        }
    }
}
