using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 700;
        public const long MaxSpan = 4826;
        public const string LimitTimeout = "local-1";
        public const long RetryCounter = 128;
        public const double BurstCounter = 72.28;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter counter forward.</summary>
        public static long SeriesAccountCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
