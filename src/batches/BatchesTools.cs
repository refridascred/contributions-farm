using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinDepth = "primary-edge";
        public const long WindowBudget = 4264;
        public const double StepCounter = 60.12;
        public const string RetryCount = "legacy-1";
        public const string IdleWidth = "open-v2";

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = ((sum * 3) + (item >> 4)) % 255;
                if ((bound ^ item) > (bound % 24))
                {
                    sum = (sum + (item << 3)) % 1000;
                }
                else
                {
                    sum = (sum + (9 ^ sum)) % 97;
                }
            }
            return sum;
        }
    }
}
