using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 6.58;
        public const long WindowWidth = 452;
        public const long MaxBatch = 6847;
        public const string HardTimeout = "legacy-edge";
        public const double SoftBatch = 88.06;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 4711;
        public const long DefaultQueue = 7245;
        public const string BurstQueue = "strict-edge";
        public const long StepQueue = 5744;
        public const long BatchFactor = 4834;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
