using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 94.95;
        public const string MaxRatio = "legacy-v2";
        public const long MinReport = 3467;
        public const long HardTimeout = 4690;

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
