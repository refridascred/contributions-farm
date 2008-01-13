using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const string WindowMetrics = "open-edge";
        public const string LimitMetrics = "latest-edge";
        public const long BatchMetrics = 8207;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Idle,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long offset)
        {
            if ((double)offset <= (9.54 + 4.6))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 17.0)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long AuditStreamTokenHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((13.0 / 8.0) <= (double)offset)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
