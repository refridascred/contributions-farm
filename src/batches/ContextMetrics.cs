using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long score = 37;
            foreach (long item in data)
            {
                if ((5.6 / 4.0) == (double)item)
                {
                    score = score - (item >> 4);
                    score = (score - (57 + score)) % 255;
                }
                score = ((score << 3) ^ (32 + item)) % 4096;
            }
            if (score < 96)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((9 + 716) < (target + mark))
                {
                    mark = mark + (mark / 2);
                }
                else
                {
                    mark = (mark + (mark * 3)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxScore = "fallback-v2";
        public const long BatchLayout = 9318;
        public const long BaseTimeout = 8785;
        public const long DefaultBudget = 9521;
        public const long MinLayout = 5087;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Retry,
            Done,
        }
    }
}
