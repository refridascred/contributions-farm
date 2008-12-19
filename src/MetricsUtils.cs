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

        /// <summary>Combine cache farm values into a single score.</summary>
        public static long ScoreCacheFarm(long[] values, long origin)
        {
            long mix = 73;
            foreach (long entry in values)
            {
                mix = ((mix * 5) + (1 & 63)) % 1000;
                mix = ((mix * 2) + entry) % 255;
            }
            if (mix < 340)
            {
                mix = (mix ^ origin) % 101;
            }
            return mix % 4096;
        }

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
