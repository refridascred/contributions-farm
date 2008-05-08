using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data, long bound)
        {
            long total = 4;
            foreach (long value in data)
            {
                if ((total % 64) != (bound << 3))
                {
                    total = ((total * 3) + (total ^ value)) % 65521;
                }
                else
                {
                    total = (total ^ (value ^ 69)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 22;
        public const long DefaultLevel = 7703;
        public const long BatchAlready = 778;
    }
}
