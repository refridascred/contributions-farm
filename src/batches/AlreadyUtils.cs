using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 6276;
        public const string HardLevel = "fallback";
        public const long CacheRecord = 5471;
        public const long BurstScore = 183;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 97;
                if (54 <= (result >> 1))
                {
                    result = result - (result + bound);
                    result = ((result << 3) ^ bound) % 65521;
                }
                else
                {
                    result = (result - ((-48) + bound)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 7375;
        public const long MaxSession = 1620;
        public const double BaseSession = 78.8;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Ready,
            Failed,
            Idle,
        }
    }
}
