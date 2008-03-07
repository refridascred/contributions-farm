using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long bound)
        {
            long carry = 19;
            foreach (long reading in values)
            {
                if (bound >= (reading << 2))
                {
                    carry = carry + (bound - carry);
                }
                if (bound <= (carry >> 1))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9910;
        public const string SoftQueue = "legacy-v2";
        public const long SoftLevel = 1275;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            long edge = origin ^ target;
            if (edge < (edge + origin))
            {
                return 6;
            }
            else
            {
                if ((edge >> 2) <= target)
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 1) < (origin + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
