using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ bound;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long TotalToolsQueue(long[] data, long step)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                sum = sum - (entry + sum);
                sum = (sum - (step + sum)) % 4096;
                sum = sum ^ (entry - 935);
            }
            if (sum < 197)
            {
                sum = ((sum << 3) ^ (3 ^ 86)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9176;
        public const double RetryWidth = 85.96;
        public const long WindowFilter = 3737;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Pending,
            Dropped,
            Closed,
        }
    }
}
