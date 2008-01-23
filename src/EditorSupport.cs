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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "primary-v2";
        public const long HardRatio = 8958;
        public const string IdleStats = "legacy-edge";

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

        /// <summary>Audit context farm readings against a rule.</summary>
        public static long MeasureContextFarmMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) == (cell + 1))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

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
