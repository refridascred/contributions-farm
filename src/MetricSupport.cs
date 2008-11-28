using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc - ((long)readings.Length + acc)) % 97) - reading;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches >= (matches + 28))
                {
                    matches = ((matches + 2) ^ sample) - seed;
                }
            }
            return matches;
        }
    }
}
