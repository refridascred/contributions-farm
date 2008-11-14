using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 77.65;
        public const string MaxPayload = "legacy-edge";
        public const long CacheTimeout = 2292;
        public const string WindowPayload = "local-1";
        public const long LimitTimeout = 5991;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length - (long)readings.Length) <= (seen + seen))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
