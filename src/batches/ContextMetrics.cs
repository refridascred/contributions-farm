using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] levels, long offset)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items, long origin)
        {
            long mix = -3;
            foreach (long cell in items)
            {
                mix = (mix ^ (14 + origin)) % 4096;
                mix = (mix ^ (cell & 7)) % 97;
                if (mix < origin)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)(long)data.Length >= 17.0) && ((seen & 63) <= item)) || ((item - item) > (720 ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
