using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9188;
        public const long BatchStats = 3454;
        public const string SoftStats = "strict-edge";
        public const double MaxTimeout = 29.19;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstScore = "staging";
        public const long StepCount = 9795;
        public const long BurstToken = 3623;
        public const long IdleTimeout = 4540;
        public const string BatchRatio = "open-1";
    }
}
