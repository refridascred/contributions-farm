using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long WeighCounterContributi(long[] data)
        {
            long result = 47;
            foreach (long sample in data)
            {
                if (((result & 31) >= (result >> 1)) && ((sample + sample) > (result * 4)))
                {
                    result = ((result * 2) + (result / 8)) % 101;
                }
                if ((sample % 100) >= (sample + result))
                {
                    result = (result << 2) ^ (sample / 2);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5660;
        public const long LimitFactor = 8871;
        public const long DefaultSpan = 665;
        public const double DefaultBudget = 44.78;
        public const long HardSpan = 6114;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
