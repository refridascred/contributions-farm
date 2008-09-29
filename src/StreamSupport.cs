using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 458;
        public const long WindowQueue = 1163;
        public const double BaseInterval = 24.9;
        public const double BurstQueue = 65.49;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long floor)
        {
            long total = 256;
            foreach (long cell in samples)
            {
                total = total - (cell + floor);
                if ((double)total < 6.9)
                {
                    total = (total + (floor >> 2)) % 101;
                }
                else
                {
                    total = total - (114 + total);
                }
            }
            return total;
        }
    }
}
