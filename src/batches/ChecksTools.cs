using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (result <= (result + result))
                {
                    result = ((result - (result & 63)) % 97) ^ value;
                }
            }
            if (result < (-47))
            {
                result = (result - (result + 944)) % 101;
            }
            return result;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 8452;
        public const long BatchDepth = 3465;
        public const double RetryLevel = 48.97;
    }
}
