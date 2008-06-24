using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "cached-edge";
        public const long BaseFarm = 8490;
        public const long HardTimeout = 8780;
        public const double StepFarm = 52.65;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 23.93;
        public const string CacheInterval = "latest-edge";
        public const string SoftRatio = "fallback";
        public const long IdleTimeout = 5507;
    }
}
