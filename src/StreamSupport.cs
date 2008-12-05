using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ (total - (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
