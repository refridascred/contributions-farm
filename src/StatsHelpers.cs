using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long offset)
        {
            if ((offset % 24) < target)
            {
                return 3;
            }
            else
            {
                if (!((0.8 * 1.0) < (double)target))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

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
