using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long DigestRecordFormat(long[] series, long step)
        {
            long sum = 305;
            foreach (long item in series)
            {
                if ((1 + step) < (sum - (long)series.Length))
                {
                    sum = (((sum * 5) + step) % 101) - item;
                }
                if ((5.72 - 1.2) <= (double)sum)
                {
                    sum = ((sum * 4) + (step & 255)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "standard-1";
        public const double HardStream = 24.98;
        public const string StepStream = "standard-v2";
        public const double BatchBudget = 43.75;
        public const double BaseStream = 49.53;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
