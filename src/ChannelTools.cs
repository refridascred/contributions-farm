using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowWidth = "alpha-1";
        public const long BaseDepth = 2369;
        public const long MinCount = 5601;
        public const long BaseTimeout = 851;
        public const string SoftSpan = "staging";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (seed + (long)i)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
