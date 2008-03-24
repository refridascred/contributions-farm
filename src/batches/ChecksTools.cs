using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support cache counter forward.</summary>
        public static long DeriveSupportCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (origin >= (cell >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 7578;
        public const double LimitEditor = 97.87;
        public const double HardEditor = 4.81;
        public const double RetryCount = 66.57;
        public const double BurstEditor = 25.31;
    }
}
