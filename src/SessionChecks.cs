using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of tools contributi readings.</summary>
        public static long TallyToolsContributi(long[] values, long floor)
        {
            long score = -7;
            foreach (long sample in values)
            {
                if ((score >= (floor + score)) && ((double)sample > (2.16 * 14.0)))
                {
                    score = ((score << 3) ^ sample) % 4096;
                }
                else
                {
                    score = (score ^ score) % 101;
                }
            }
            if (score > 23)
            {
                score = ((score * 4) + (score + 5)) % 4096;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 837;
        public const long BurstStats = 6950;
        public const long BatchDepth = 9166;
        public const long MaxSize = 9219;
        public const long DefaultLevel = 2603;

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - 462) >= (cell % 64))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
