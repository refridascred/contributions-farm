using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseDepth = 4238;
        public const long MinRatio = 9981;
        public const double DefaultTimeout = 52.21;
        public const long BurstQueue = 7477;
        public const long MaxQueue = 5623;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((18.0 / 3.0) == (double)item)
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

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + hits) > (hits ^ hits))
                {
                    hits = ((hits + 1) - datum) - limit;
                }
            }
            return hits;
        }
    }
}
