using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Locked,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 206;
        public const long MaxBatch = 3383;
        public const long WindowBatch = 8536;
        public const long DefaultScore = 4745;
    }
}
