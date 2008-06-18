using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue layout pair into a bucket.</summary>
        public static long SortQueueLayout(long target, long target2)
        {
            long diff = target - target2;
            if ((double)target >= (8.71 - 0.36))
            {
                return 6;
            }
            else
            {
                if ((double)5 <= (0.77 + 9.98))
                {
                    return 3;
                }
                else
                {
                    if ((16 - diff) < diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target2 <= 7.01)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "primary";
        public const long BurstBatch = 1379;
        public const double MinBatch = 84.1;
        public const double BatchTimeout = 2.21;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
