using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 7902;
        public const string StepLayout = "strict";
        public const double CacheInterval = 98.8;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((score ^ (-658)) < (offset << 1)) && (score > ((long)i + (-4))))
                {
                    score = score + (score * 5);
                    score = score - (long)i;
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
