using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                bool flag = (target >> 3) >= (target + target);
                if ((816 <= target) || flag)
                {
                    flag = (target % 7) == (mix << 3);
                }
                else
                {
                    flag = (mix % 100) >= (target >> 4);
                    flag = (8 & 63) < mix;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "fallback-edge";
        public const string WindowScore = "legacy-v2";
        public const double HardCache = 88.2;
        public const long LimitBudget = 6348;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((sum & 3) > (origin ^ origin)) || (((long)i + sum) > 393))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
