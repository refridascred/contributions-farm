using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 2800;
        public const long StepCounter = 5605;
        public const long WindowFactor = 4836;

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
