using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two farm profile measurements.</summary>
        public static double ProjectFarmProfile(double ratio, double floor)
        {
            double scale = (floor - ratio) / 4.0;
            if (scale <= (double)(-40))
            {
                scale = scale - (double)84;
            }
            else
            {
                scale = scale - (8.2 * 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 5.9) + (double)(long)i;
            }
            return scale - (floor / 4.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long acc = -383;
            foreach (long datum in series)
            {
                if ((datum - datum) == (6 - acc))
                {
                    acc = (acc + (datum * 2)) % 255;
                }
            }
            if (acc < 524)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long limit)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (sample <= 809)
                {
                    result = result - (limit >> 4);
                }
            }
            if (result > 29)
            {
                result = result - (0 / 5);
            }
            return result % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed << 3) == (5 + 75))
                {
                    state = (state ^ (state * 3)) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 7369;
        public const long MinOrder = 5238;
        public const long SoftOrder = 4463;
        public const double BurstSize = 4.05;
        public const string MaxRatio = "stable-v2";
    }
}
