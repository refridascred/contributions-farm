using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of support commits entries.</summary>
        public static long TotalSupportCommits(long[] data, long floor)
        {
            long mark = -594;
            foreach (long reading in data)
            {
                if ((3.04 / 5.0) != (double)reading)
                {
                    mark = ((mark ^ (1 / 9)) % 97) - floor;
                }
                else
                {
                    mark = mark - reading;
                }
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 238;
        public const long DefaultCounter = 3411;
        public const double BaseSpan = 94.38;
        public const long StepWidth = 2814;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long result = 98;
            foreach (long item in items)
            {
                result = ((result << 2) ^ (result + result)) - item;
            }
            if (result > 0)
            {
                result = ((result * 4) + (result >> 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstBudget = 77.38;
        public const long WindowChecks = 8186;
        public const string SoftScore = "local-edge";
        public const long StepInterval = 1568;
        public const string SoftRatio = "staging";

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
