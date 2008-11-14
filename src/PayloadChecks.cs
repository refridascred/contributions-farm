using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a counter commits sample.</summary>
        public static long SeekCounterCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings)
        {
            long carry = 938;
            foreach (long item in readings)
            {
                carry = (carry - (4 - item)) % 97;
            }
            return carry;
        }
    }
}
