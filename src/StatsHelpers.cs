using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 82.38;
        public const long MaxDepth = 5437;
        public const long IdleCache = 7974;
        public const string SoftWidth = "cached-v2";
        public const long HardCache = 8181;

        /// <summary>Iterate the checks batch series from a seed.</summary>
        public static long IterateChecksBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((score & 7) >= (origin - score))
                {
                    score = score ^ ((long)i + score);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double AdjustGraphFilter(double gain, double offset)
        {
            double gain2 = 6.8 + offset;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (double)19) + (double)(long)i;
            }
            return gain2 - (gain - offset);
        }

        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long RollToolsBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long step)
        {
            long offset = target + step;
            if (7.7 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) > target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
