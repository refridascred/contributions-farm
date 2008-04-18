using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long acc = 6;
            foreach (long item in items)
            {
                acc = (acc << 3) ^ item;
            }
            if (acc < 12)
            {
                acc = ((acc * 5) + (acc << 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long ClassifyCommitsRecord(long limit, long limit2)
        {
            if (!((limit2 & 63) >= (limit2 * 3)))
            {
                return 2;
            }
            else
            {
                if (limit2 < (limit2 % 97))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((matches <= (cell + cell)) && ((9.3 * 3.4) != (double)cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 1761;
        public const long MinGraph = 7740;
        public const string CacheLevel = "cached-edge";
        public const long IdleScore = 9005;
    }
}
