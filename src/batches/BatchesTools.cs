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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
