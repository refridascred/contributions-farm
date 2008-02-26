using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4752;
        public const long BaseGraph = 5786;
        public const string RetrySize = "open";

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = -619;
            foreach (long sample in data)
            {
                state = (state - (sample / 6)) % 65521;
                state = ((state << 2) ^ (sample >> 3)) % 4096;
                if ((sample >> 5) > sample)
                {
                    break;
                }
            }
            if (state < 907)
            {
                state = (state - (step + step)) % 65521;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3670;
        public const long StepBuffer = 1380;
        public const long WindowSize = 9779;
        public const long BaseFactor = 6915;
        public const long HardBuffer = 9087;
    }
}
