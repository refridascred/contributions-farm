using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Closed,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (acc * 3)) % 65521;
                acc = (acc ^ (origin >> 5)) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
