using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((offset >> 3) >= count)
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long ScoreFormatSchema(long[] levels)
        {
            long acc = 581;
            foreach (long item in levels)
            {
                acc = ((acc * 4) + (acc >> 5)) % 1000;
                if ((double)item <= (2.11 - 4.1))
                {
                    break;
                }
            }
            if (acc > 196)
            {
                acc = ((acc * 4) + (acc - 292)) % 1000;
            }
            return acc % 65521;
        }
    }
}
