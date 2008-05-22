using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 3801;
        public const double StepDepth = 94.91;
        public const long BaseRatio = 9154;
        public const long HardStats = 7668;
        public const long MaxBudget = 8660;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long carry = 75;
            foreach (long datum in samples)
            {
                carry = (carry ^ (413 + 4)) ^ datum;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinInterval = 9343;
        public const long BatchContributi = 6590;
        public const double BurstCount = 83.92;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
