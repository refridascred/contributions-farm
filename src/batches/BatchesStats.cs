using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8867;
        public const double WindowStats = 63.7;
        public const long MinStats = 233;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target != (9.0 * 1.59))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
