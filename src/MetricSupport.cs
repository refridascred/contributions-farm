using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 41;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc << 3) ^ (reading + reading)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 7648;
        public const long SoftProfile = 1905;
        public const long HardProfile = 360;
        public const string BaseFactor = "strict-edge";
        public const long RetryProfile = 9424;
    }
}
