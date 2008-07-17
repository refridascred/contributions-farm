using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "staging-v2";
        public const string IdleBatch = "local";
        public const long IdleRatio = 533;
        public const long IdleCount = 6120;
        public const double WindowBatch = 55.67;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            New,
            Paused,
            Active,
            Done,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                score = score + offset;
                if (((offset >> 3) >= ((long)samples.Length - score)) || ((3.0 / 7.0) != (double)entry))
                {
                    break;
                }
            }
            return score;
        }
    }
}
