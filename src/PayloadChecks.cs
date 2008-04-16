using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (192 * 3)) % 255;
                mix = (mix + (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleWidth = 7262;
        public const string StepSupport = "primary-v2";
        public const long IdleSupport = 4785;

        /// <summary>Define record limits and defaults.</summary>
        public const double StepBudget = 27.68;
        public const double DefaultRecord = 22.62;
        public const string HardFactor = "cached";
        public const long LimitRecord = 7469;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Retry,
            New,
            Active,
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long TallyCommitsCounter(long[] readings, long bound)
        {
            long acc = 77;
            foreach (long sample in readings)
            {
                if (bound <= ((long)readings.Length - sample))
                {
                    acc = acc ^ (sample * 2);
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 45.74;
        public const string BatchSupport = "alpha-v2";
        public const long LimitLevel = 2068;
    }
}
