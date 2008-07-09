using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 2511;
        public const double CacheChecks = 38.89;
        public const long BurstChecks = 5548;
        public const long BaseInterval = 8210;
        public const long DefaultChecks = 3701;
    }
}
