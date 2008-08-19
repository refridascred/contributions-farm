using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
