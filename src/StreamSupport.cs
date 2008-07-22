using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) >= origin)
                {
                    result = ((result << 3) ^ result) % 1000;
                }
                else
                {
                    result = (result + origin) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryScore = "latest-1";
        public const long SoftFactor = 3507;
        public const double MaxStream = 3.07;
    }
}
