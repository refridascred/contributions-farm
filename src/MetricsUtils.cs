using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Failed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long FoldEntryCache(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (offset >= (offset & 31))
                {
                    anchor = (((anchor * 5) + (17 + offset)) % 101) - sample;
                }
                else
                {
                    anchor = (anchor << 3) ^ (36 - 28);
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - (offset % 64)) ^ (long)i;
                }
                anchor = (anchor - 252) % 65521;
                if ((anchor ^ anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
