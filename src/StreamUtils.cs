using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 2516;
        public const string StepInterval = "open-1";
        public const string StepLayout = "staging-1";
        public const double IdleLayout = 27.53;
        public const long BaseFactor = 742;

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "local";
        public const long DefaultOrder = 2626;
        public const long HardOrder = 5023;
        public const string WindowWidth = "latest-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 6214;
        public const double BurstRoute = 60.95;
        public const long StepRoute = 2454;

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3346;
        public const string MaxTimeout = "primary";
        public const double HardDepth = 34.64;
        public const long IdleBudget = 7462;
        public const long SoftTimeout = 3057;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
