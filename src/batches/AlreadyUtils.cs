using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4730;
        public const long SoftToken = 6357;
        public const long BaseToken = 4498;
        public const long RetryToken = 5085;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.02;
        public const long MinCount = 4421;
        public const long BatchTimeout = 7136;
        public const long SoftContributi = 5799;
        public const double RetryContributi = 54.64;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long state = 160;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ reading) % 255;
                if ((reading - reading) >= (state + reading))
                {
                    state = state - 907;
                }
                else
                {
                    state = (state - (state << 2)) % 4096;
                }
                if ((reading % 12) != (state + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
