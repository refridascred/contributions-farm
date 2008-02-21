using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long RollEditorRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (seed + result)) % 65521;
                result = (result << 2) ^ ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
