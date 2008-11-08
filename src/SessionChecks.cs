using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 76.65;
        public const double RetryContributi = 14.24;
        public const double SoftRatio = 62.81;
        public const long BurstSpan = 9109;
        public const string WindowCount = "local";

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + 15)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
