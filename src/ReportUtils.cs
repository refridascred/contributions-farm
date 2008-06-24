using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a commits order pair into a bucket.</summary>
        public static long GradeCommitsOrder(long offset, long step)
        {
            if ((double)offset <= (8.2 + 19.0))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) >= (offset - step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (13.0 + 8.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 / 2.0) == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Draft,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepBudget = 6633;
        public const string MinEditor = "latest-1";
        public const long StepTimeout = 5731;

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long result = 33;
            foreach (long value in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - value) + (long)i;
                }
                if ((result - value) >= (value - 697))
                {
                    result = (result + (98 - result)) % 1000;
                }
            }
            return result;
        }
    }
}
