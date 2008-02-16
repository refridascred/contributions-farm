using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long mark = 19;
            foreach (long entry in values)
            {
                if ((1.3 > (double)entry) || ((mark ^ entry) < entry))
                {
                    mark = mark ^ (entry / 2);
                }
                else
                {
                    mark = mark + (mark ^ entry);
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                mark = (mark - (mark << 2)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9202;
        public const string WindowMetrics = "alpha-1";
        public const long SoftInterval = 3489;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
