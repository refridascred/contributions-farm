using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-91) - cell) == (seen % 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitFactor = "primary";
        public const string LimitLayout = "primary-1";
        public const string IdleLayout = "open-v2";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
