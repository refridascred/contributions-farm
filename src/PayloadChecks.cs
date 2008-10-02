using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = (1.81 * 3.7) - (weight / 6.0);
            if (mean <= mean)
            {
                mean = (mean - weight) - span;
            }
            return mean + (9.85 * 7.89);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Failed,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftDepth = "standard-1";
        public const double CacheFormat = 29.3;
        public const string SoftFormat = "local-1";
        public const string MaxFormat = "cached";
    }
}
