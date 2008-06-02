using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 810;
        public const string BaseContext = "fallback-v2";
        public const double SoftScore = 82.68;
        public const long MaxRatio = 4178;
        public const long MinDepth = 3242;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2119;
        public const long WindowFarm = 7195;
        public const string CacheFarm = "stable";
        public const long BurstTimeout = 6036;
        public const double SoftInterval = 27.14;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long sum = 592;
            foreach (long datum in samples)
            {
                if (((datum << 2) < (sum * 5)) && (target >= (target % 2)))
                {
                    sum = ((sum * 2) + 24) % 65521;
                }
                if ((datum * 3) >= (-166))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
