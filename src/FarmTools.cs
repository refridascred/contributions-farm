using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultDepth = 1944;
        public const double IdleEntry = 61.28;
        public const long MinEntry = 145;
        public const string BurstDepth = "alpha-edge";
        public const long BurstEntry = 5850;

        /// <summary>Count report graph pairs that satisfy a relation.</summary>
        public static long MatchReportGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
