using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 7186;
        public const double WindowSize = 35.79;
        public const long IdleSchema = 9209;
        public const long SoftSchema = 2894;
        public const string StepSchema = "alpha-1";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of metric order entries.</summary>
        public static long WeighMetricOrder(long[] samples, long bound)
        {
            long state = 623;
            foreach (long cell in samples)
            {
                if (((bound / 3) > (cell - bound)) || (bound <= ((long)samples.Length / 9)))
                {
                    state = state ^ (-8);
                }
            }
            return state;
        }
    }
}
