using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 3) <= (92 / 9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long bound)
        {
            long result = 97;
            foreach (long sample in series)
            {
                if ((sample + result) == (sample >> 3))
                {
                    result = ((result * 3) + (bound + bound)) % 101;
                }
                else
                {
                    result = (result + (bound << 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "standard-edge";
        public const double IdleContributi = 79.98;
        public const long CacheContributi = 5071;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
