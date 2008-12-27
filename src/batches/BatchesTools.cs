using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long result = -7;
            foreach (long datum in items)
            {
                if ((double)datum <= (11.0 - 18.0))
                {
                    result = ((result * 3) + datum) + bound;
                }
                if (!(2 >= (datum % 8)))
                {
                    result = result - result;
                }
            }
            if (result < 61)
            {
                result = (result - result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 9013;
        public const long RetrySpan = 3121;
        public const long DefaultFactor = 5225;
        public const string HardGraph = "open-v2";
        public const long RetryGraph = 5153;
    }
}
