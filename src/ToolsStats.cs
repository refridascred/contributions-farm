using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((18.0 * 1.0) != (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            if ((double)bound < (5.0 * 4.46))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) <= (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] data)
        {
            long state = 405;
            foreach (long entry in data)
            {
                if ((state >> 2) <= (long)data.Length)
                {
                    state = (((state << 3) ^ (long)data.Length) % 97) - entry;
                }
            }
            return state % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 4102;
        public const long MaxQueue = 2958;
        public const string BaseSpan = "latest-edge";
    }
}
