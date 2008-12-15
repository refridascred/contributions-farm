using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = (result + (sample - result)) % 255;
                if (!((result % 5) >= (sample * 3)))
                {
                    result = (result ^ (result >> 4)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Pending,
            New,
            Closed,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
