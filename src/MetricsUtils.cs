using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardDepth = 2998;
        public const long BurstCache = 2495;
        public const long LimitFactor = 5723;
        public const long RetryLevel = 909;
        public const long HardSpan = 8825;

        /// <summary>Digest a series of batches record entries.</summary>
        public static long TallyBatchesRecord(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((double)value <= (5.34 + 19.0))
                {
                    mix = (mix * 3) + (mix >> 3);
                }
                if (((4 ^ value) > (mix % 100)) && ((value * 2) < (value >> 4)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 65.0;
        public const long HardSession = 8929;
        public const long CacheSession = 7202;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
