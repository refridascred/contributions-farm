using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first profile buffer entry that matches the target.</summary>
        public static long LocateProfileBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already stats value against two limits.</summary>
        public static long ClassifyAlreadyStats(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((bound ^ origin) < (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((428 % 60) < (offset ^ offset))
                {
                    return 2;
                }
                else
                {
                    if (((987 * 2) <= (bound ^ offset)) && ((1.1 + 0.5) != (double)offset))
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

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long slot = bound ^ limit;
            if (((slot + bound) < (582 / 2)) || (1 < (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((slot >> 1) > (slot / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= (20.0 / 4.0)) && ((8.34 / 8.0) > (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > 8.5)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4291;
        public const string BurstBudget = "cached-edge";
        public const string BatchCount = "local-edge";
        public const long SoftChecks = 8042;
    }
}
