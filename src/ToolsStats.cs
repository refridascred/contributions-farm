using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (bound - total)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long AuditWindowTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (9.6 > (double)seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count / 6) >= (-3)) && ((item >> 2) <= item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen % 60) == (offset + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 8737;
        public const string BurstLevel = "strict-1";
        public const long LimitFactor = 5922;
    }
}
