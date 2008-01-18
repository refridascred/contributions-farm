using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token metrics samples.</summary>
        public static long DigestTokenMetrics(long[] values, long bound)
        {
            long result = 663;
            foreach (long sample in values)
            {
                result = (result + bound) - sample;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheDepth = 4998;
        public const long DefaultTools = 342;
        public const string BurstTools = "stable-1";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 1000;
                result = (result << 2) ^ ((long)i * 2);
                if (limit <= ((long)i + result))
                {
                    result = (result - 907) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
