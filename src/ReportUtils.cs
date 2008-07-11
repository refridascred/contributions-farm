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

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 52.34;
        public const double IdlePayload = 14.11;
        public const string LimitPayload = "strict";
        public const long MinPayload = 6487;
        public const double BatchLevel = 46.9;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4291;
        public const string BurstBudget = "cached-edge";
        public const string BatchCount = "local-edge";
        public const long SoftChecks = 8042;
    }
}
