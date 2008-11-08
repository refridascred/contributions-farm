using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 71.42;
        public const long StepInterval = 1654;
        public const double BurstChannel = 14.55;
        public const long LimitChannel = 8186;
        public const long HardTimeout = 8757;

        /// <summary>Validate support record readings against a bound.</summary>
        public static bool VerifySupportRecordBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
