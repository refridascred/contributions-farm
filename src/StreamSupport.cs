using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Pending,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + cell) < (matches - step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
