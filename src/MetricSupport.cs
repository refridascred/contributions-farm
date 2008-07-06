using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const double CacheScore = 46.48;
        public const long IdleWidth = 8680;

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long limit)
        {
            long next = offset ^ limit;
            if (!((next - next) <= (next ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((next <= (next + next)) && ((double)offset >= (double)next))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
