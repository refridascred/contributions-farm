using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double weight = (double)(346 + 86);
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight + (span / 7.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (mark >= ((-406) ^ value))
                {
                    mark = mark + (mark ^ value);
                }
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Queued,
            Active,
        }
    }
}
