using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((mix >> 5) <= (717 - origin))
                {
                    mix = ((mix << 2) ^ (long)i) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 6748;
        public const double BurstInterval = 18.81;
        public const long MinTimeout = 8239;
        public const string SoftSpan = "open";
        public const long BurstLevel = 2738;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Draft,
            Paused,
        }
    }
}
