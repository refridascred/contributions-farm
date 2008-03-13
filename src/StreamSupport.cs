using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-edge";
        public const double MaxEditor = 7.74;
        public const long BaseWidth = 2807;
        public const string BurstEditor = "standard";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 7249;
        public const long StepScore = 8536;
        public const long WindowProfile = 7140;
        public const string IdleProfile = "strict-edge";
        public const long StepProfile = 6001;
    }
}
