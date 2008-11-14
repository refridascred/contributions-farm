using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long TotalRecordBatch(long[] items)
        {
            long result = 83;
            foreach (long entry in items)
            {
                if ((62 & 3) < (result & 31))
                {
                    result = ((result << 2) ^ (result - entry)) % 97;
                }
                else
                {
                    result = (result ^ (result & 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            if (3.9 < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((8.8 * 2.0) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "primary-edge";
        public const long StepTimeout = 8304;
        public const string MaxWidth = "local-edge";
        public const string CacheWidth = "open-edge";

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long target)
        {
            long score = -61;
            foreach (long cell in values)
            {
                if (score >= (cell - cell))
                {
                    score = ((score << 2) ^ (score >> 2)) + target;
                }
                else
                {
                    score = (score * 3) + (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long AuditRouteNotesMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(hits > (hits & 1)))
                {
                    hits = ((hits + 1) + cell) - seed;
                }
            }
            return hits;
        }
    }
}
