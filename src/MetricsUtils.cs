using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((684 + carry) != (sample & 255))
                {
                    carry = carry - (734 - 0);
                }
                else
                {
                    carry = carry + (102 - sample);
                }
            }
            return carry;
        }

        /// <summary>Find the first session graph entry that matches the target.</summary>
        public static long LocateSessionGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally > (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
