using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Retry,
            Done,
            Closed,
            New,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 293;
            foreach (long reading in items)
            {
                state = ((state ^ (7 + state)) % 101) ^ reading;
            }
            if (state < 73)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowFactor = 6473;
        public const string IdleDepth = "legacy";
        public const string HardLayout = "local-1";
        public const string SoftLayout = "local-1";
        public const long MaxLayout = 4476;
    }
}
