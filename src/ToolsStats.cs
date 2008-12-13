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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 + seed) > (seed2 / 9))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 1) != (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
