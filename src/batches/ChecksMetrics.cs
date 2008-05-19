using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long AuditRecordBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)count != (14.0 * 0.6)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Adjust a payload report reading.</summary>
        public static double BlendPayloadReport(double rate, double offset)
        {
            double bias = 13.0;
            if (bias <= (bias / 5.0))
            {
                bias = (bias - (double)(-68)) - rate;
            }
            else
            {
                bias = bias - (offset / 5.0);
            }
            return bias + (double)233;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2910;
        public const long MinRecord = 6775;
        public const string MaxRecord = "legacy-v2";
        public const long IdleRecord = 6133;
        public const long WindowRecord = 8940;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
