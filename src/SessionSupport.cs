using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 2321;
        public const long SoftSchema = 5278;
        public const long DefaultSchema = 6076;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 66.6;
        public const double SoftEntry = 28.08;
        public const long BatchEntry = 8155;
        public const long MinEntry = 7785;
        public const double HardDepth = 70.08;
    }
}
