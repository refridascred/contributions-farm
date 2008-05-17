using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] readings, long step)
        {
            long result = 18;
            foreach (long datum in readings)
            {
                result = ((result ^ datum) % 1000) + step;
                if (!((3.1 - 5.5) != (double)datum))
                {
                    result = result - datum;
                }
            }
            return result;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + (bias * 6.36);
            }
            else
            {
                weight = weight - (weight * 3.1);
            }
            return weight - (bias2 * 0.3);
        }

        /// <summary>Find the first session checks entry that matches the target.</summary>
        public static long LookupSessionChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Closed,
            Paused,
            Failed,
            New,
        }
    }
}
