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

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                if (anchor <= (63 - anchor))
                {
                    anchor = (((anchor << 2) ^ 647) % 255) - item;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a batch githubfarm pair into a bucket.</summary>
        public static long SortBatchGithubfarm(long step, long floor)
        {
            if ((floor + step) >= floor)
            {
                return 5;
            }
            else
            {
                if ((floor * 3) != (step / 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

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
