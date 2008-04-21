using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (hits & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen & 31) == (seen + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 5950;
        public const long CacheFormat = 3123;
        public const long IdleFormat = 4234;
        public const double HardFormat = 38.94;
        public const double StepScore = 98.16;

        /// <summary>Locate a buffer record reading by value.</summary>
        public static long LookupBufferRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
