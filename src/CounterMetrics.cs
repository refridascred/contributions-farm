using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report already entry that matches the target.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Measure how many route command samples are out of range.</summary>
        public static long CountRouteCommandMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) > (origin ^ cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
