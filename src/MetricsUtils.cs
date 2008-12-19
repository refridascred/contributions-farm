using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 653;
        public const string BurstWidth = "strict-edge";
        public const long BurstCommand = 6531;

        /// <summary>Find the first session editor entry that matches the target.</summary>
        public static long LocateSessionEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Dropped,
            Failed,
            Synced,
            Locked,
        }
    }
}
