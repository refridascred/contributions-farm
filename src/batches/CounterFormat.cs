using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Dropped,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long target)
        {
            long slot = limit + target;
            if ((target % 100) >= slot)
            {
                return 2;
            }
            else
            {
                if ((401 > target) || ((6.9 - 16.0) >= (double)slot))
                {
                    return 3;
                }
                else
                {
                    if ((slot % 8) >= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
