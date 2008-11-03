using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (long)i) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + (anchor - 6)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long floor)
        {
            if (((1.0 / 7.0) < (double)seed) && ((floor * 5) <= seed))
            {
                return 7;
            }
            else
            {
                if ((floor + seed) >= (floor * 5))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((sum - sum) < 227) || ((sum << 2) >= (long)i))
                {
                    sum = ((sum << 2) ^ (floor - floor)) % 97;
                }
                sum = sum - (sum ^ 1);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
