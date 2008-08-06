using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + count) <= (count - 895)) && !((double)cell >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
