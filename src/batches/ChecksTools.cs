using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowRatio = 1674;
        public const string BaseTools = "strict-1";
        public const long MinTools = 8451;
        public const double LimitFactor = 67.91;

        /// <summary>Count already batch pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context batches readings.</summary>
        public static long TallyContextBatches(long[] levels)
        {
            long sum = -50;
            foreach (long datum in levels)
            {
                sum = (sum * 5) + datum;
            }
            if (sum < 232)
            {
                sum = (sum + (sum / 7)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
