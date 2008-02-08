using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "open";
        public const string WindowDepth = "local-1";
        public const string MinProfile = "standard-v2";
        public const long WindowLevel = 5777;

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < (reading + (-9)))
                {
                    mix = (mix + mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (limit ^ reading)) % 255;
                }
            }
            if (mix < 674)
            {
                mix = ((mix * 5) + (limit - mix)) % 4096;
            }
            return mix;
        }
    }
}
