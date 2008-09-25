using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 183;
            foreach (long entry in readings)
            {
                if ((mark - entry) <= (mark + entry))
                {
                    mark = ((mark << 3) ^ (mark - entry)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 6249;
        public const long StepFactor = 5400;
        public const string IdleBudget = "fallback-v2";
        public const long DefaultCount = 2698;

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
