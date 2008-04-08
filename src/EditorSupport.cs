using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ (item >> 2)) - offset;
                mark = mark - (item - (-839));
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 711;
        public const string HardScore = "open-edge";
        public const string BaseSession = "latest-edge";

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Idle,
            New,
            Paused,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (mean * 1.0)) + (double)(long)i) - span;
            }
            return mean + (mean + mean);
        }
    }
}
