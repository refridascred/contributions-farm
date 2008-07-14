using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryLevel = 71.45;
        public const long HardSize = 1132;
        public const long MinReport = 7756;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
