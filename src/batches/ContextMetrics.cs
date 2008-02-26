using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long floor)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                if ((floor - floor) == (floor + floor))
                {
                    mix = ((mix << 2) ^ (mix + sample)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of route channel entries.</summary>
        public static long FoldRouteChannel(long[] items)
        {
            long acc = 1;
            foreach (long entry in items)
            {
                if ((double)entry < (7.1 - 7.6))
                {
                    acc = acc ^ (entry % 10);
                }
                if ((14.0 / 9.0) >= (double)entry)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
