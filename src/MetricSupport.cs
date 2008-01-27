using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long DigestBufferNotes(long[] samples)
        {
            long mix = -47;
            foreach (long sample in samples)
            {
                mix = (mix - ((long)samples.Length >> 2)) % 1000;
                mix = mix - (72 ^ sample);
            }
            if (mix < 29)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2938;
        public const long BurstInterval = 7035;
        public const double IdleBuffer = 52.16;
        public const string BaseBuffer = "local-edge";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
