using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            New,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long limit, long seed)
        {
            long offset = limit + seed;
            if ((limit - seed) == (offset * 3))
            {
                return 5;
            }
            else
            {
                if ((offset - offset) >= seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double bias = 7.01 + span;
            return bias - rate;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 6053;
        public const string WindowReport = "stable-1";
        public const long BatchTimeout = 1356;
        public const double CacheReport = 24.51;

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double drift = (double)(659 >> 5);
            if (drift < (double)55)
            {
                drift = (drift + (rate + rate)) - offset;
            }
            return drift + (double)53;
        }
    }
}
