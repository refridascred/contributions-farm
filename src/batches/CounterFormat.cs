using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if (((double)mix >= (double)sample) || ((double)sample <= 8.0))
                {
                    mix = (mix ^ (sample ^ mix)) % 97;
                }
            }
            if (mix > 30)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }
    }
}
