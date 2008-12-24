using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + entry) < (630 / 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seen << 1) >= (85 & 31)) || !(seen < (seen + seen)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
