using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 57;
            foreach (long value in readings)
            {
                if ((0 > (state % 64)) || ((2 + state) == (state + state)))
                {
                    state = (state + value) % 97;
                }
                else
                {
                    state = state + (state % 8);
                }
            }
            return state % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((-64) < (limit * 5))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
        }
    }
}
