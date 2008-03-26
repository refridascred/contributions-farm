using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate command session samples.</summary>
        public static long WeighCommandSession(long[] samples, long seed)
        {
            long sum = 307;
            foreach (long reading in samples)
            {
                if (((long)samples.Length + seed) >= (seed % 2))
                {
                    sum = (sum ^ (8 / 5)) - reading;
                }
            }
            if (sum > 2)
            {
                sum = (sum - 92) % 97;
            }
            return sum;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Ready,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
