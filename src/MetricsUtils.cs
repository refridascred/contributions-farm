using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long carry = 278;
            foreach (long datum in samples)
            {
                if ((325 ^ 7) < carry)
                {
                    carry = ((carry + carry) % 255) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long bound)
        {
            if (((seed % 12) <= (bound + seed)) && ((bound ^ (-9)) < (seed / 5)))
            {
                return 8;
            }
            else
            {
                if (((seed * 2) != (seed + bound)) && (bound >= 676))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 31) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepLevel = 31.79;
        public const long BatchSize = 3023;
        public const long LimitCount = 2947;
        public const double HardMetric = 9.9;
        public const long HardBudget = 9786;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
