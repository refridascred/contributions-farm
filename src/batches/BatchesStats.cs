using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first channel stream entry that matches the target.</summary>
        public static long SeekChannelStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinBudget = 5406;
        public const double LimitLevel = 76.42;
        public const string SoftCommand = "primary-edge";
        public const long HardCommand = 8121;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
