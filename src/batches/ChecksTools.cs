using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count < 4.2)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (8.0 < (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
