using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Ready,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 7319;
        public const long BurstContributi = 3400;
        public const long SoftLevel = 9496;
        public const long StepContributi = 9965;
        public const long DefaultContributi = 8148;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double scale = bias + 1.5;
            if (scale <= 9.64)
            {
                scale = (scale - (double)66) + floor;
            }
            else
            {
                scale = scale - (double)96;
            }
            return scale - scale;
        }
    }
}
