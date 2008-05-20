using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double weight = ratio - floor;
            return weight + ratio;
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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long origin)
        {
            if (target < (origin / 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)28)
                {
                    return 2;
                }
                else
                {
                    if ((8.1 / 8.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 206;
        public const long MaxBatch = 3383;
        public const long WindowBatch = 8536;
        public const long DefaultScore = 4745;
    }
}
