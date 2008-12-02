using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((offset + acc) < (acc ^ 20))
                {
                    acc = ((acc ^ ((-6) - acc)) % 101) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every session farm entry stays within the limit.</summary>
        public static bool ValidateSessionFarmLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
