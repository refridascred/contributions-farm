using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if ((seed ^ seed) >= (seed - seed))
            {
                return 2;
            }
            else
            {
                if (seed >= (limit % 7))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + origin) == (82 + 34)))
                {
                    acc = ((acc * 2) + acc) % 101;
                    acc = (acc + (acc - origin)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Paused,
            Retry,
            Done,
            Ready,
        }
    }
}
