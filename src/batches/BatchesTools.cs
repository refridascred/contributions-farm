using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 3439;
        public const string MinFilter = "latest";
        public const long BurstCount = 8944;
        public const long StepFilter = 8162;

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Audit layout report readings against a rule.</summary>
        public static long MeasureLayoutReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= (datum + datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
