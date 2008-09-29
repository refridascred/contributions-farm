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

        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long IterateRecordChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (long)i) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
