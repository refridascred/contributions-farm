using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((1.8 - 7.0) <= (double)count)
                {
                    count = ((count + 2) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }
    }
}
