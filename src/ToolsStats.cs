using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long score = 272;
            foreach (long reading in values)
            {
                if ((floor % 60) == (reading - reading))
                {
                    score = score ^ score;
                }
                if ((floor - reading) <= (score & 7))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 3443;
        public const long BaseAlready = 9303;
        public const string BaseDepth = "latest-v2";
        public const long MaxAlready = 8512;
        public const string HardCount = "standard-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "stable-v2";
        public const double BatchRatio = 70.42;
        public const double CacheBudget = 70.24;
    }
}
