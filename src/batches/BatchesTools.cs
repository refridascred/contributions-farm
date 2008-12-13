using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank order commits input into a small class.</summary>
        public static long GradeOrderCommits(long seed, long seed2)
        {
            if ((0.89 - 7.0) <= (double)seed2)
            {
                return 0;
            }
            else
            {
                if ((seed / 5) < (seed + seed2))
                {
                    return 7;
                }
                else
                {
                    if (!((seed2 ^ seed2) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 - seed) >= (seed2 & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
