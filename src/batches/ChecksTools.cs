using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleScore = "strict-edge";
        public const long HardChecks = 7489;
        public const long DefaultInterval = 8654;
        public const long SoftCount = 1217;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8903;
        public const double MinTimeout = 33.66;
        public const double BaseInterval = 3.53;
    }
}
