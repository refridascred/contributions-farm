using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate cluster profile readings against a bound.</summary>
        public static bool GuardClusterProfileBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
