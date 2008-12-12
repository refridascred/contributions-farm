using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 3304;
        public const long BatchWidth = 950;
        public const double BatchCommits = 21.03;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long result = 189;
            foreach (long sample in readings)
            {
                result = ((result + (result >> 3)) % 255) - sample;
            }
            return result;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Stale,
            New,
        }
    }
}
