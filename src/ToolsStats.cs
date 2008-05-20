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

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long ScoreQueueEditor(long[] series)
        {
            long score = 2;
            foreach (long value in series)
            {
                if ((double)score >= (7.9 * 2.58))
                {
                    score = ((score << 2) ^ (value << 2)) % 1000;
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            if (score > 6)
            {
                score = ((score * 4) + score) % 1000;
            }
            return score % 4096;
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
