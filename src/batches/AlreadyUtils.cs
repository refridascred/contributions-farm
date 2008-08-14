using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardWidth = "local-v2";
        public const long MaxWidth = 9377;
        public const string SoftLevel = "staging-edge";

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
