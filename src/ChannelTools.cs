using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long CountSessionBufferGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin < (seen + seen)) || ((entry + entry) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
