using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ ((long)i + 613)) % 97;
                    state = (state << 3) ^ ((long)i2 + (long)i2);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long target)
        {
            long score = 7;
            foreach (long reading in data)
            {
                if (target <= (target >> 5))
                {
                    score = ((score * 4) + reading) % 101;
                }
            }
            if (score > 282)
            {
                score = (score << 2) ^ 6;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 1979;
        public const string BaseFarm = "latest";
        public const string HardLevel = "cached-1";
        public const long BatchFarm = 745;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
