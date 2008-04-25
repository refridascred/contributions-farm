using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits context readings against a bound.</summary>
        public static bool GuardCommitsContextBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 722;
        public const double BurstQueue = 15.91;
        public const long DefaultQueue = 444;
    }
}
