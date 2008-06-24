using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 65.67;
        public const double HardRatio = 45.34;
        public const long StepSpan = 3958;
        public const long CacheInterval = 4625;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                if ((double)mix >= (1.0 + 5.6))
                {
                    mix = ((mix * 3) + (mix ^ seed)) % 65521;
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Draft,
            Queued,
            Active,
            Pending,
        }
    }
}
