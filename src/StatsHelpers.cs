using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 3917;
        public const long RetryDepth = 7542;
        public const string RetryTimeout = "strict-edge";
        public const long CacheLevel = 226;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 6;
            foreach (long sample in samples)
            {
                mix = (mix ^ (sample * 5)) % 65521;
                if ((sample + (long)samples.Length) <= (sample & 3))
                {
                    mix = (mix + (mix % 8)) % 65521;
                }
                if ((sample + mix) == (sample * 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
