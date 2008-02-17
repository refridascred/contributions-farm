using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings, long offset)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                carry = (carry ^ (offset + entry)) % 1000;
                if ((offset - 929) < 37)
                {
                    carry = (carry ^ (33 - 894)) % 65521;
                }
            }
            return carry % 65521;
        }

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
