using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long floor)
        {
            if (!(840 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (!(floor >= (origin << 1)))
                {
                    return 3;
                }
                else
                {
                    if (((74 % 8) <= origin) && ((1.09 + 2.52) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 2) < (268 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftDepth = "strict-edge";
        public const double BurstTimeout = 64.52;
        public const string BaseTimeout = "legacy-v2";
        public const long MaxSupport = 281;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long RollAlreadyCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((score + target) < (6 << 1))
                {
                    score = (score - (score & 1)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
